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
    public string Name;

    public Tadpole(Sprite sprite, string color, string name, double speed)
    {
        Sprite = sprite;
        Color = color;
        Speed = speed;
        Name = name;

    }

    public Sprite GetSprite()
    {
        return this.Sprite;
    }

    public void SetColor(string color)
    {
        this.Color = color;

        if (Color == "Green")
        {

        } else if (Color == "Blue") 
        {

        } else if (Color == "Red")
        {

        }
    }

}

public class Frog : Tadpole
{
    public double JumpHeight;

    public Frog(Sprite sprite, string color, string name, double speed, double jumpHeight)
        : base(sprite, color, name, speed)
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

public class ColourComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return (new CaseInsensitiveComparer()).Compare(((Tadpole)x).Color,
               ((Tadpole)y).Color);
    }
}

public class FrogOrder : MonoBehaviour
{
    public Button[] buttons = new Button[10];

    public static Tadpole[] TadpoleArray = new Tadpole[10];

    void Start()
    {
        //{
        //new Frog(sourceImage1, "e", 1, 1), new Frog(sourceImage2, "e", 3, 3), new Tadpole(sourceImage3, "e", 6), new Frog(sourceImage4, "e", 7, 7), new Frog(sourceImage5, "e", 10, 10),
        // new Frog(sourceImage6, "e", 1, 1), new Tadpole(sourceImage7, "e", 4), new Frog(sourceImage8, "e", 2, 2), new Frog(sourceImage9, "e", 9, 9), new Frog(sourceImage10, "e", 8, 8)
        //};
    }

    public void SpeedSort()
    {
        Array.Sort(TadpoleArray, new SpeedComparer());
    }

    public void ColourSort()
    {
        Array.Sort(TadpoleArray, new ColourComparer());
    }

    void Update()
    {

        for (int i = 0; i < FrogEnabler.intfrogs; i++) 
        {
            buttons[i].GetComponent<Image>().sprite = TadpoleArray[i].GetSprite();
        }
    }
 }