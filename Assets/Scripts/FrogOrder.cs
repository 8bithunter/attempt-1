using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogOrder : MonoBehaviour
{
    public Image sourceImage1;
    public Image sourceImage2;
    public Image sourceImage3;
    public Image sourceImage4;
    public Image sourceImage5;
    public Image sourceImage6;
    public Image sourceImage7;
    public Image sourceImage8;
    public Image sourceImage9;
    public Image sourceImage10;

    public Image button00;
    public Button button10;
    public Button button20;
    public Button button30;
    public Button button40;
    public Button button01;
    public Button button11;
    public Button button21;
    public Button button31;
    public Button button41;

    public class Frog
    {
        public Image image;
        public int number;

        public Frog(Image image, int number)
        {
            this.image = image;
            this.number = number;
        }

    }


    void Start()
    {
        button00 = sourceImage1;
    }

    void Update()
    {
        //Frog[,] frogs = {{new Frog(sourceImage1, 5), new Frog(sourceImage2, 3), new Frog(sourceImage3, 6), new Frog(sourceImage4, 7), new Frog(sourceImage5, 10)},
       //                  {new Frog(sourceImage6, 1), new Frog(sourceImage7, 4), new Frog(sourceImage8, 2), new Frog(sourceImage9, 9), new Frog(sourceImage10, 8)}};

       // Button[,] buttons = {{button00, button10, button20, button30, button40},
        //                     {button01, button11, button21, button31, button41}};

        


    }
}
