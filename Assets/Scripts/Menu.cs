using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOptions()
    {
        // Options menüsünü açmak için gerekli kodlar buraya eklenebilir.
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene(7);
    }

    public void BackButton()
    {

    }


    public void SetValume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

