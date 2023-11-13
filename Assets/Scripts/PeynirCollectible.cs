using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeynirCollectible : MonoBehaviour
{   
    // Start is called before the first frame update

    private MeshRenderer m_MeshRenderer;
    private Collider m_Collider;
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();  
        m_Collider = GetComponent<Collider>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Vector3 newScale =  new Vector3(0.1f, 0.1f, 0.1f);
            other.transform.localScale += newScale;
            StartCoroutine("OneSecondHide");
            
        }
    }

    IEnumerator OneSecondHide()
    {
        m_MeshRenderer.enabled = false;
        m_Collider.enabled = false;
        yield return new WaitForSeconds(1);
        m_MeshRenderer.enabled = true;
        m_Collider.enabled = true;
    }
}
