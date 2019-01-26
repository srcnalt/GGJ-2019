using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    private Animator itemAnimator;
    public bool isQuestItem;
    public Action RevealQuestItemInPanel;
    public string message;

    private void Start()
    {
        itemAnimator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isQuestItem)
        {
            itemAnimator.Play("Found");
            RevealQuestItemInPanel.Invoke();
        }
    }
}
