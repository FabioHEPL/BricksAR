using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothAr : MonoBehaviour
{
    Vector3 localOffset;
    [Range(0.1f,1)]
    public float smoothness=0.5f; 

    private void Awake()
    {
        StartCoroutine(Smoothing());
    }

    IEnumerator Smoothing()
    {
        localOffset = transform.localPosition;

        Vector3 lastPosition = transform.position;

        while (true)
        {
            lastPosition = transform.position;
            transform.position = Vector3.Lerp(lastPosition, transform.TransformPoint(localOffset),smoothness);
            yield return null;
        }
    }
}
