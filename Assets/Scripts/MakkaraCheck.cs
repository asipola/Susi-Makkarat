using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakkaraCheck : MonoBehaviour
{
    public float lifetime;
    // Start is called before the first frame update
   public void makkaralife()
    {
        lifetime += Time.fixedDeltaTime;
       
    }
}
