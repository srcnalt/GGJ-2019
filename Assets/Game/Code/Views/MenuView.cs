using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Views
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField] private Transform menuBG;
        [SerializeField] private AudioSource audioSource;

        private void Update()
        {
            menuBG.Rotate(Vector3.forward, Time.deltaTime * 10);
        }

        public void LoadIntroLevel()
        {
            audioSource.Play();
            SceneManager.LoadSceneAsync("Intro");
        }
        
        public void LoadCreditsLevel()
        {
            audioSource.Play();
            SceneManager.LoadSceneAsync("Credits");
        }
        
        /*
         * Code is shit? I don't care.
         */
    }
}