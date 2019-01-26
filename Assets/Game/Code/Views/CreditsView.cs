using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Views
{
    public class CreditsView : MonoBehaviour
    {
        public void LoadMenuScene()
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadSceneAsync("menu");
        }
    }
}