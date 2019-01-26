using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    private Animator itemAnimator;
    public bool isQuestItem;

    private void Start()
    {
        itemAnimator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("test");
        
        if (isQuestItem)
        {
            itemAnimator.Play("Found");
        }
    }
}
