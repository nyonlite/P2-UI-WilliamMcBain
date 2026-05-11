using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuUi; // brings up pause ui 
    public bool isPaused = false;


    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f; //  resume game time
        isPaused = false;
    }
    public void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f; // Freeze game time
        isPaused =true;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
