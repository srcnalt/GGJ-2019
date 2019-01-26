using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestItem : MonoBehaviour
{
    [SerializeField] private Image image;
    
    public void Reveal()
    {
        image.color = Color.white;
    }

    public void SetSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
