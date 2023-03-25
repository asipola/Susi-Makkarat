using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireManager : MonoBehaviour
{
    public Transform makkaraPosition;
    public Transform makkaraPrefab;
    public MakkaraCheck makkaraCurrent;
    int score;
    private void OnTriggerStay(Collider collider)
    {
       
        if (collider.GetComponent<MakkaraCheck>() is MakkaraCheck makkara)
        {
            makkara.makkaralife();
            if (makkara.lifetime >= 10)
            {
                Debug.Log("Makkara on valmis");
                Destroy(makkara.gameObject);
                score++;
            }
        }
    }
    public void spawnmakkara()
    {
        Transform makkara = Instantiate(makkaraPrefab,makkaraPosition);
        makkaraCurrent = makkara.GetComponent < MakkaraCheck>();
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnmakkara();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
