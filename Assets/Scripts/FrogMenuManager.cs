using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FrogMenuManager : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        if (button == null)
        {
            Debug.LogError("Button component not found on the GameObject.");
            return;
        }
    }

    public Sprite GetButtonSprite()
    {
        if (button != null && button.image != null)
        {
            return button.image.sprite;
        }
        else
        {
            Debug.LogWarning("Button or button's image not found.");
            return null;
        }
    }
}