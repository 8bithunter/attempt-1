using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogEnabler : MonoBehaviour
{
    public int intfrogs;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;

    public void intfrogplus()
    {
        intfrogs++;
    }

    public void intfrogminus()
    {
        intfrogs--;
    }

    void Update()
    {
        if (intfrogs <= 0)
        {
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 1)
        {
            button1.SetActive(true);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 2)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 3)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 4)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 5)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 6)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 7)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(false);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 8)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(false);
            button10.SetActive(false);
        }

        if (intfrogs == 9)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(true);
            button10.SetActive(false);
        }

        if (intfrogs >= 10)
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(true);
            button10.SetActive(true);
        }
    }
}
