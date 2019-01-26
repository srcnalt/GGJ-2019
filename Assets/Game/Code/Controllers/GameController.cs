using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text itemMessageField;
    [SerializeField] private QuestItem questItemPrefab;
    [SerializeField] private Transform questItemsContainer; 
    [SerializeField] private Item[] items;
    [SerializeField] private Image blackCover;
    [SerializeField] private Text scoreText;
    
    private const int ACTIVE_ITEM_COUNT = 5;
    private int foundItemCount;
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

                var newQuestItem = Instantiate<QuestItem>(questItemPrefab, questItemsContainer);
                newQuestItem.SetSprite(items[randomNum].GetComponent<Image>().sprite);
                items[randomNum].RevealQuestItemInPanel += newQuestItem.Reveal;
                items[randomNum].RevealQuestItemInPanel += () => StartCoroutine(PrintText(items[randomNum].message));
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

    private IEnumerator PrintText(string text)
    {
        itemMessageField.text = "";
        
        for (int i = 0; i < text.Length; i++)
        {
            itemMessageField.text += text[i];
            yield return null;
        }

        foundItemCount++;

        if (foundItemCount == ACTIVE_ITEM_COUNT)
        {
            scoreText.text = $"You cleaned your room in { (int)Time.timeSinceLevelLoad } seconds!";
            
            yield return new WaitForSeconds(3);
            float alpha = 0;

            while (blackCover.color.a < 1)
            {
                alpha += Time.deltaTime;
                blackCover.color = new Color(0, 0, 0, alpha);
                scoreText.color = new Color(1, 1, 1, alpha);
                yield return null;
            }
            
            yield return new WaitForSeconds(3);

            SceneManager.LoadSceneAsync("Credits");
        }
    }
}
