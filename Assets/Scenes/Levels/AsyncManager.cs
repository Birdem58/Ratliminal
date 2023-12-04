using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Bu metot, butona t?kland???nda ça?r?labilir
    public void LoadGame()
    {
        // Loading sahnesine geçi?
        SceneManager.LoadScene("LoadingScene");

        // ?lerleyen bir zamanda Level0 sahnesine geçi?
        Invoke("LoadLevel0", 2f); // 2 saniye sonra geçi?
    }

    void LoadLevel0()
    {
        SceneManager.LoadScene("Level0");
    }
}
