using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    private Animator itemAnimator;
    private bool isFound;
        
    public bool isQuestItem;
    public string message;
    public Action RevealQuestItemInPanel;

    private void Start()
    {
        itemAnimator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isQuestItem && !isFound)
        {
            itemAnimator.Play("Found");
            RevealQuestItemInPanel.Invoke();
            isFound = true;
        }
    }
}
