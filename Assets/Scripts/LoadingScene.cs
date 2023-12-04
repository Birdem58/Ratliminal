using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    public GameObject loadingScreen;
    public Image loadingBarFill;

    // Bu metot, sahnenin yüklenme sürecini başlatır
    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    // Sahnenin yüklenme sürecini gösteren IEnumerator metodu
    IEnumerator LoadSceneAsync(int sceneId)
    {
        // Loading ekranını aktifleştir
        loadingScreen.SetActive(true);

        // Asenkron olarak sahneyi yükle
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneId);

        // Yükleme sürecini takip et
        while (!asyncOperation.isDone)
        {
            // Yükleme çubuğunu güncelle
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f); // 0.9, sahne yükleninceye kadar olan ilerlemenin tamamlandığı noktadır
            loadingBarFill.fillAmount = progress;

            yield return null; // Bir sonraki frame'i bekle
        }

        // Yükleme tamamlandığında loading ekranını deaktifleştir
        loadingScreen.SetActive(false);
    }
}
