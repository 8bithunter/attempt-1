using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tadpole
{
    public Sprite Sprite;
    public string Color;
    public double Speed;

    public Tadpole(Sprite sprite, string color, int speed)
    {
        Sprite = sprite;
        Color = color;
        Speed = speed;
    }

    public Sprite GetSprite()
    {
        return this.Sprite;
    }

}

public class Frog : Tadpole
{
    public double JumpHeight;

    public Frog(Sprite sprite, string color, int speed, float jumpHeight)
        : base(sprite, color, speed)
    {
        JumpHeight = jumpHeight;
    }
}

public class SpeedComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return (new CaseInsensitiveComparer()).Compare(((Tadpole)x).Speed,
               ((Tadpole)y).Speed);
    }
}

public class FrogOrder : MonoBehaviour
{
    public Sprite sourceImage1;
    public Sprite sourceImage2;
    public Sprite sourceImage3;
    public Sprite sourceImage4;
    public Sprite sourceImage5;
    public Sprite sourceImage6;
    public Sprite sourceImage7;
    public Sprite sourceImage8;
    public Sprite sourceImage9;
    public Sprite sourceImage10;

    public Button button00;
    public Button button10;
    public Button button20;
    public Button button30;
    public Button button40;
    public Button button01;
    public Button button11;
    public Button button21;
    public Button button31;
    public Button button41;

    public Tadpole[] TadpoleArray;

       void Start()
       {
            TadpoleArray = new Tadpole[]
            {
                new Frog(sourceImage1, "e", 1, 1), new Frog(sourceImage2, "e", 3, 3), new Frog(sourceImage3, "e", 6, 6), new Frog(sourceImage4, "e", 7, 7), new Frog(sourceImage5, "e", 10, 10),
                new Frog(sourceImage6, "e", 1, 1), new Frog(sourceImage7, "e", 4, 4), new Frog(sourceImage8, "e", 2, 2), new Frog(sourceImage9, "e", 9, 9), new Frog(sourceImage10, "e", 8, 8)
            };
       }

        public void SpeedSort()
        {
            Array.Sort(TadpoleArray, new SpeedComparer());
        }

       void Update()
       {
           Image buttonImage00 = button00.GetComponent<Image>();
           buttonImage00.sprite = TadpoleArray[0].GetSprite();

           Image buttonImage10 = button10.GetComponent<Image>();
           buttonImage10.sprite = TadpoleArray[1].GetSprite();

           Image buttonImage20 = button20.GetComponent<Image>();
           buttonImage20.sprite = TadpoleArray[2].GetSprite();

           Image buttonImage30 = button30.GetComponent<Image>();
           buttonImage30.sprite = TadpoleArray[3].GetSprite();

           Image buttonImage40 = button40.GetComponent<Image>();
           buttonImage40.sprite = TadpoleArray[4].GetSprite();

           Image buttonImage01 = button01.GetComponent<Image>();
           buttonImage01.sprite = TadpoleArray[5].GetSprite();

           Image buttonImage11 = button11.GetComponent<Image>();
           buttonImage11.sprite = TadpoleArray[6].GetSprite();

           Image buttonImage21 = button21.GetComponent<Image>();
           buttonImage21.sprite = TadpoleArray[7].GetSprite();

           Image buttonImage31 = button31.GetComponent<Image>();
           buttonImage31.sprite = TadpoleArray[8].GetSprite();

           Image buttonImage41 = button41.GetComponent<Image>();
           buttonImage41.sprite = TadpoleArray[9].GetSprite();
       }
 }