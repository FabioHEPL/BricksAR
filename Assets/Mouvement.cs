using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    [SerializeField]
    private Transform from;

    [SerializeField]
    private Transform to;

    [SerializeField]
    private float time = 5f;

    [SerializeField]
    private bool bounce = false;

    [SerializeField]
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = from.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < time)
        {
            currentTime += Time.deltaTime;
            transform.position = Vector3.Lerp(from.position, to.position, currentTime / time);
            Debug.Log(currentTime / time);
        }
        else
        {
            Invert();
            currentTime = 0f;
        }
    }

    private void Invert()
    {
        Vector3 fromPosition = from.position;
        from.position = to.position;
        to.position = fromPosition;
    }
}
