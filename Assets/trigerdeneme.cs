using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerdeneme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0f,50f,0f);
        Debug.Log("trigerred");
    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = new Vector3(0f, 50f, 0f);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0f, 50f, 0f);
    }
}
