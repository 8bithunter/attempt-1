using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondSprites : MonoBehaviour
{
    public SpriteRenderer[] FrogRenderers = new SpriteRenderer[10];
    public SpriteRenderer[] TadpoleRenderers = new SpriteRenderer[10];

    public GameObject[] FrogObjects = new GameObject[10];
    public GameObject[] TadpoleObjects = new GameObject[10];

    void Start()
    {
        Tadpole[] tadpoleArray = FrogOrder.TadpoleArray;

        for (int i = 0; i < 10; i++)
        {
            FrogObjects[i].SetActive(false);
            TadpoleObjects[i].SetActive(false);
        }

        for (int i = 0; i < FrogEnabler.staticintfrogs; i++)
        {
            if (tadpoleArray[i] is Frog)
            {
                FrogObjects[i].SetActive(true);
                TadpoleObjects[i].SetActive(false);
                FrogRenderers[i].sprite = tadpoleArray[i].GetSprite();
            }
            else
            {
                FrogObjects[i].SetActive(false);
                TadpoleObjects[i].SetActive(true);
                TadpoleRenderers[i].sprite = tadpoleArray[i].GetSprite();
            }
        }
    }
}