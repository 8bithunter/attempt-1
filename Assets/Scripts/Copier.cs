using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ImageSpriteCopier : MonoBehaviour
{
    public Image sourceImage00;
    public Image sourceImage10;
    public Image sourceImage20;
    public Image sourceImage30;
    public Image sourceImage40;
    public Image sourceImage01;
    public Image sourceImage11;
    public Image sourceImage21;
    public Image sourceImage31;
    public Image sourceImage41;
    public Image targetImage;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI ColourText;
    public TextMeshProUGUI SpeedText;

    public void CopySprite00()
    {
        if (sourceImage00 != null && sourceImage00.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage00.sprite;
            NameText.text = FrogOrder.TadpoleArray[0].Name;
            ColourText.text = FrogOrder.TadpoleArray[0].Color;
            SpeedText.text = FrogOrder.TadpoleArray[0].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite10()
    {
        if (sourceImage10 != null && sourceImage10.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage10.sprite;
            NameText.text = FrogOrder.TadpoleArray[1].Name;
            ColourText.text = FrogOrder.TadpoleArray[1].Color;
            SpeedText.text = FrogOrder.TadpoleArray[1].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite20()
    {
        if (sourceImage20 != null && sourceImage20.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage20.sprite;
            NameText.text = FrogOrder.TadpoleArray[2].Name;
            ColourText.text = FrogOrder.TadpoleArray[2].Color;
            SpeedText.text = FrogOrder.TadpoleArray[2].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite30()
    {
        if (sourceImage30 != null && sourceImage30.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage30.sprite;
            NameText.text = FrogOrder.TadpoleArray[3].Name;
            ColourText.text = FrogOrder.TadpoleArray[3].Color;
            SpeedText.text = FrogOrder.TadpoleArray[3].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite40()
    {
        if (sourceImage40 != null && sourceImage40.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage40.sprite;
            NameText.text = FrogOrder.TadpoleArray[4].Name;
            ColourText.text = FrogOrder.TadpoleArray[4].Color;
            SpeedText.text = FrogOrder.TadpoleArray[4].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite01()
    {
        if (sourceImage01 != null && sourceImage01.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage01.sprite;
            NameText.text = FrogOrder.TadpoleArray[5].Name;
            ColourText.text = FrogOrder.TadpoleArray[5].Color;
            SpeedText.text = FrogOrder.TadpoleArray[5].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite11()
    {
        if (sourceImage11 != null && sourceImage11.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage11.sprite;
            NameText.text = FrogOrder.TadpoleArray[6].Name;
            ColourText.text = FrogOrder.TadpoleArray[6].Color;
            SpeedText.text = FrogOrder.TadpoleArray[6].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite21()
    {
        if (sourceImage21 != null && sourceImage21.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage21.sprite;
            NameText.text = FrogOrder.TadpoleArray[7].Name;
            ColourText.text = FrogOrder.TadpoleArray[7].Color;
            SpeedText.text = FrogOrder.TadpoleArray[7].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite31()
    {
        if (sourceImage31 != null && sourceImage31.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage31.sprite;
            NameText.text = FrogOrder.TadpoleArray[8].Name;
            ColourText.text = FrogOrder.TadpoleArray[8].Color;
            SpeedText.text = FrogOrder.TadpoleArray[8].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
    public void CopySprite41()
    {
        if (sourceImage41 != null && sourceImage41.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage41.sprite;
            NameText.text = FrogOrder.TadpoleArray[9].Name;
            ColourText.text = FrogOrder.TadpoleArray[9].Color;
            SpeedText.text = FrogOrder.TadpoleArray[9].Speed.ToString();
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
}
