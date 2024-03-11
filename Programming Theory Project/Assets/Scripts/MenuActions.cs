using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    // Call this method when the Play button is clicked
    public void PlayGame()
    {
        // Replace "MainScene" with the name of your main scene
        SceneManager.LoadScene("Main");
    }

    public void MainMenu()
    {
        // Replace "MainScene" with the name of your main menu scene
        SceneManager.LoadScene("Menu");
    }

    // Call this method when the Quit button is clicked
    public void QuitGame()
    {
        // This will close the application
        Application.Quit();
    }

    // Call this method when the Options button is clicked
    public void ToggleSound()
    {
        // This will toggle the sound volume between 0 (off) and 1 (on)
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}
