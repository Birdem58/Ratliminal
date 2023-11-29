using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PovDegis : MonoBehaviour
{

    public CinemachineVirtualCamera followCamera;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {


        followCamera.m_Lens.FieldOfView = 150f;
    }

    private void Update()
    {
        timer = Time.time;
        
        if (timer > 0.1f && followCamera.m_Lens.FieldOfView >60)
        {
            followCamera.m_Lens.FieldOfView -= 2f;
            timer = 0f;
        }
          
    }




}
