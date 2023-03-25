using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AseManager : MonoBehaviour
{
    public LayerMask mask;
    public Camera cm;
    public StickControl sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sc.isCooking == true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("BOOM!");
            if(Physics.Raycast(cm.transform.position, cm.transform.forward, out RaycastHit hit,1000,mask)){
                if (hit.collider.tag == "Susi")
                {
                    Debug.Log("Ammuit sutta");
                }
            }
        }
    }
}
