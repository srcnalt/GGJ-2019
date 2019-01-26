using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Views
{
    public class IntroView : MonoBehaviour
    {
        [SerializeField] private GameObject[] stages;
        
        private IEnumerator Start()
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                yield return null;
            }
            
            yield return null;
            
            stages[0].SetActive(false);
            stages[1].SetActive(true);
            
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                yield return null;
            }
            
            yield return null;
            
            stages[1].SetActive(false);
            stages[2].SetActive(true);
            
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                yield return null;
            }

            SceneManager.LoadSceneAsync("Game");
        }
    }
}