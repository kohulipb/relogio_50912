using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMgr : MonoBehaviour
{
    public float timeFlow = 1f;

    void Start()
    {
        Time.fixedDeltaTime = timeFlow;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, -0.1f , relativeTo: Space.World);
    }
}
