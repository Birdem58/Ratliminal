using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private const string V = "Level0";
    private const string SceneName = V;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneName); // "GameScene" sahnesine geçis yapabilirsiniz.
    }