using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGecis : MonoBehaviour
{
    
    public void MenuyeGec()
    {
        SceneManager.LoadScene(0);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene(0);

        }
    }
}
