using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerdivenGirisCollider : MonoBehaviour
{
    private Merdivenici merdivenici;
    private float counter;
    private float refreshTime = 0.5f;
    private float temp;
    private float oPos;
    private float sPos;
    [SerializeField] private bool girdi = false;
    
    // Start is called before the first frame update
    void Start()
    {
        merdivenici = GetComponent<Merdivenici>();
        
    }

    // Update is called once per frame
    void Update()
    {
        merdivenici.isOnMerdiven = girdi;
        counter += Time.deltaTime;
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   
               girdi = true;                       
        }
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sPos = other.transform.position.y;
            if (counter >= refreshTime)
            {
                temp = sPos - oPos ;
                oPos = sPos;
                counter = 0;
                Debug.Log(temp);

                if (temp >= 0.1f)
                {
                    Vector3 negativeScale = new Vector3(0.05f, 0.05f, 0.05f);
                    Vector3 minimumScale = new Vector3(0.5f, 0.5f, 0.5f);

                    

                    
                    if (other.transform.localScale.x > minimumScale.x && other.transform.localScale.y > minimumScale.y && other.transform.localScale.z > minimumScale.z)
                    {
                        other.transform.localScale -= negativeScale;
                    }
                    else
                    {
                        
                        other.transform.localScale = minimumScale;
                    }
                }

            }






        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {      
                girdi = false;
        }
    }

}
