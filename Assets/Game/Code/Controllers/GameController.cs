using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Item[] items;
    
    private const int ACTIVE_ITEM_COUNT = 5;
    private int[] selectedNumbers = new int[ACTIVE_ITEM_COUNT];

    private void Start()
    {
        for (int i = 0; i < ACTIVE_ITEM_COUNT; i++)
        {
            int randomNum = GetRandomNumber();

            if(!selectedNumbers.Contains(randomNum))
            {
                selectedNumbers[i] = randomNum;
                items[randomNum].isQuestItem = true;
                
                Debug.Log(randomNum);
            }
            else
            {
                i--;
            }
        }
    }

    private int GetRandomNumber()
    {
        return Random.Range(0, items.Length);
    }
}
