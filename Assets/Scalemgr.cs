using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scalemgr : MonoBehaviour
{
    public GameObject relogio;
    public GameObject cam;
    Vector3 camMove = new Vector3 (0, 0, -10f);
    void Awake()
    {
       
    }
    void FixedUpdate()
    {
        
        switch(relogio.transform.eulerAngles.z)
        {
            case 359f:
                this.transform.localScale /= 1.2f;
                break;
            case 0:
                this.transform.localScale *= 1.2f;
                break;
            

        }
        Debug.Log("" + relogio.transform.eulerAngles.z);
        
    }
}
