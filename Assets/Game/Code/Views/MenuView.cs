using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Views
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField] private Transform menuBG;

        private void Update()
        {
            menuBG.Rotate(Vector3.forward, Time.deltaTime * 10);
        }

        public void LoadIntroLevel()
        {
            SceneManager.LoadSceneAsync("Intro");
        }
        
        public void LoadCreditsLevel()
        {
            SceneManager.LoadSceneAsync("Credits");
        }
        
        /*
         * Code is shit? I don't care.
         */
    }
}