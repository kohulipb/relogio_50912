using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float timeFlow = 1f;

    void Start()
    {
        Time.fixedDeltaTime = timeFlow;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, -0.00833333333f , relativeTo: Space.World);
    }
}
