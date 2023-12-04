using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Bu metot, butona t?kland???nda �a?r?labilir
    public void LoadGame()
    {
        // Loading sahnesine ge�i?
        SceneManager.LoadScene("LoadingScene");

        // ?lerleyen bir zamanda Level0 sahnesine ge�i?
        Invoke("LoadLevel0", 2f); // 2 saniye sonra ge�i?
    }

    void LoadLevel0()
    {
        SceneManager.LoadScene("Level0");
    }
}
