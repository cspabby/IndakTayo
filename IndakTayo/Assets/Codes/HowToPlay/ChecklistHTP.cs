using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistHTP : MonoBehaviour
{
    public GameObject IMUChecklist;
    public GameObject DestroyChecklist;
    public GameObject ChecklistCanvasIMU;
    public GameObject DestroyCollider;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IMUChecklist.SetActive(true);

            ChecklistCanvasIMU.SetActive(true);


            Destroy(DestroyCollider);


            if(DestroyChecklist !=null)
            {
                DestroyChecklist.SetActive(false);
            }
        }


   
    }
}
