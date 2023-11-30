using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Transform pickUptarget;
    [SerializeField] private float pickUpRange;

    private Rigidbody currentObejct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {

            if(currentObejct)
            {
                currentObejct.useGravity = true;
                currentObejct = null;
                return;
            }
            Ray cameraRay = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if(Physics.Raycast(cameraRay,out RaycastHit hitInfo, pickUpRange ,pickUpMask))
            {
                currentObejct = hitInfo.rigidbody;
                currentObejct.useGravity = false;

            }

        }
    }

    private void FixedUpdate()
    {
        if(currentObejct)
        {
            Vector3 directionToPoint = pickUptarget.position - currentObejct.position;
            float distanceToPoint = directionToPoint.magnitude;

            currentObejct.velocity = directionToPoint * 12f * distanceToPoint;
        }
    }
}
