using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeynirCollectible : MonoBehaviour
{
    // Start is called before the first frame update

    private MeshRenderer m_MeshRenderer;
    private Collider m_Collider;
    public float maxScale = 2.5f;
    public float artýsScale = 0.1f;
    public bool isCollectible;

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
        if (other.CompareTag("Player"))
        {
            Vector3 maximumScale = new Vector3(maxScale, maxScale, maxScale);
            if (other.transform.localScale.x < maximumScale.x && other.transform.localScale.y < maximumScale.y && other.transform.localScale.z < maximumScale.z)
            {
                Vector3 newScale = new Vector3(artýsScale, artýsScale, artýsScale);
                other.transform.localScale += newScale;
            }
            else
            {
                other.transform.localScale = maximumScale;
            }
            
                StartCoroutine("OneSecondHide");
            


        }
        }

        IEnumerator OneSecondHide()
        {
            m_MeshRenderer.enabled = false;
            m_Collider.enabled = false;
            yield return new WaitForSeconds(1);
            if(isCollectible)
            {
            m_MeshRenderer.enabled = true;
            m_Collider.enabled = true;
            }
            
        }
    } 
