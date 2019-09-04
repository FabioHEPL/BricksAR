using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{

    private Quaternion rotation;

    void Start()
    {
        rotation = Quaternion.Euler(Vector3.zero);
    }

    void Update()
    {

        gameObject.transform.rotation = rotation;

    }
}
