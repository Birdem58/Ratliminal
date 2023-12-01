using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4Trigger : MonoBehaviour
{
    public Transform spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        
            other.transform.position = spawnPoint.position;
        
    }

    private void OnTriggerStay(Collider other)
    {
        
            other.transform.position = spawnPoint.position;
        
    }

    private void OnTriggerExit(Collider other)
    {
        
            other.transform.position = spawnPoint.position;

    }
}
