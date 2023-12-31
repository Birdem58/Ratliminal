using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{

    public Transform spawnPoint;
    
    
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0f, 50f, 0f);
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
