using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickControl : MonoBehaviour
{
    public CampfireManager cfm;
    public Animator sm;
    public bool isCooking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Toimii");
            sm.SetBool("IsCooking", true);
            isCooking =true;
        }
        if(Input.GetMouseButtonUp(0))    
        {
            Debug.Log("Toimii2");
            sm.SetBool("IsCooking", false);
            StopAllCoroutines();
            StartCoroutine(stickDelay());
           
        }
    }
    IEnumerator stickDelay()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        isCooking = false;
        if(cfm.makkaraCurrent == null)
        {
            cfm.spawnmakkara();

        }

    }
}
