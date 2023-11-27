using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerdivenGirisCollider : MonoBehaviour
{
   // private Merdivenici merdivenici;
    private float counter;
    private float refreshTime = 0.5f;
    private float temp;
    private float oPos;
    private float sPos;
    private float jHeight;
    private float stepOffset;
    public float minScale = 0.5f;
    public float negScale = 0.05f;
    public float stepOfLim = 0.1f;
    [SerializeField] private bool girdi = false;
    [SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
       // merdivenici = GetComponent<Merdivenici>();


    }

    // Update is called once per frame
    void Update()
    {
       // merdivenici.isOnMerdiven = girdi;
        counter += Time.deltaTime;
                

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdPersonController = other.GetComponent<ThirdPersonController>();
            characterController = other.GetComponent<CharacterController>();
            stepOffset = characterController.stepOffset;
            jHeight = thirdPersonController.JumpHeight;
            girdi = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdPersonController = other.GetComponent<ThirdPersonController>();
            characterController = other.GetComponent<CharacterController>();
            thirdPersonController.JumpHeight = 0;
            sPos = other.transform.position.y;
            if (counter >= refreshTime)
            {
                temp = sPos - oPos;
                oPos = sPos;
                counter = 0;
                Debug.Log(temp);

                if (temp >= 0.1f)
                {
                    Vector3 negativeScale = new Vector3(negScale, negScale, negScale);
                    Vector3 minimumScale = new Vector3(minScale, minScale, minScale);
                   




                    if (other.transform.localScale.x > minimumScale.x && other.transform.localScale.y > minimumScale.y && other.transform.localScale.z > minimumScale.z)
                    {
                        other.transform.localScale -= negativeScale;
                    }
                    else
                    {
                        other.transform.localScale = minimumScale;
                        characterController.stepOffset = stepOfLim;
                    }
                }

            }






        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdPersonController = other.GetComponent<ThirdPersonController>();
            characterController = other.GetComponent<CharacterController>();
            characterController.stepOffset = stepOffset;
            thirdPersonController.JumpHeight = jHeight;
            girdi = false;
        }
    }

}
