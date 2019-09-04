using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAxis : MonoBehaviour
{

    private float axisYLocked;

    void Start()
    {
        axisYLocked = gameObject.transform.position.y;
    }

    void LateUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x, axisYLocked, transform.position.z);
    }

}
