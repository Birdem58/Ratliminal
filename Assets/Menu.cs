using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("level0");
    }

    public void OpenOptions()
    {
        // Options menüsünü açmak için gerekli kodlar buraya eklenebilir.
    }

    public void OpenCredits()
    {
        // Credits menüsünü açmak için gerekli kodlar buraya eklenebilir.
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

