using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Reflection;

public class StoreManager : MonoBehaviour
{
    public TMP_InputField InputField;
    public TMP_Dropdown dropdown;
    public Image StoreFrog;
    public Sprite GreenFrog;
    public Sprite BlueFrog;
    public Sprite RedFrog;
    public Sprite GreenTad;
    public Sprite BlueTad;
    public Sprite RedTad;
    public Sprite ActiveSprite;
    private string EnteredText;
    private string Colour;
    private System.Random random = new System.Random();


    private void Start()
    {
        // Subscribe to the dropdown's OnValueChanged event
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        ActiveSprite = GreenTad;
    }

    private void OnDropdownValueChanged(int index)
    {
        if (dropdown.options[index].text == "Green")
        {
            ActiveSprite = GreenTad;
            Colour = "Green";
        } else if (dropdown.options[index].text == "Blue")
        {
            ActiveSprite = BlueTad;
            Colour = "Blue";
        } else if (dropdown.options[index].text == "Red")
        {
            ActiveSprite = RedTad;
            Colour = "Red";
        }
        Debug.Log("Selected option: " + dropdown.options[index].text);
    }

    public void Birth()
    {
        FrogOrder.TadpoleArray[FrogEnabler.staticintfrogs] = new Tadpole(ActiveSprite, Colour, EnteredText, random.NextDouble());
        FrogEnabler.intfrogplus();
    }

    private void Update()
    {
        if (InputField != null)
        {
            EnteredText = InputField.text;
        }

        StoreFrog.sprite = ActiveSprite;

    }
}
