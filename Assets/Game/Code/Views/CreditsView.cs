using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Views
{
    public class CreditsView : MonoBehaviour
    {
        public void LoadMenuScene()
        {
            SceneManager.LoadSceneAsync("menu");
        }
    }
}