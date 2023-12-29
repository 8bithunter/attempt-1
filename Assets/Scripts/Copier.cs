using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void CopySprite00()
    {
        if (sourceImage00 != null && sourceImage00.sprite != null && targetImage != null)
        {
            targetImage.sprite = sourceImage00.sprite;
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
        }
        else
        {
            Debug.LogWarning("Source or target image or sprite not found.");
        }
    }
}
