using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public TMP_InputField InputField;
    public TMP_Dropdown dropdown;
    public Sprite frwog;
    private string EnteredText;

    private void Start()
    {
        // Subscribe to the dropdown's OnValueChanged event
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int index)
    {
        // Handle the event here, using the selected index or value
        Debug.Log("Selected option: " + dropdown.options[index].text);
    }

    public void Birth()
    {
        FrogOrder.TadpoleArray[FrogEnabler.staticintfrogs] = new Tadpole(frwog, EnteredText, 5);
        FrogEnabler.intfrogplus();
    }

    private void Update()
    {
        if (InputField != null)
        {
            EnteredText = InputField.text;
        }
    }
}
