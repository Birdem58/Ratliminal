using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RforRestart : MonoBehaviour
{
    public int sceneIndex;
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
