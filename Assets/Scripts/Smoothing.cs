using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoothing : MonoBehaviour
{
    [SerializeField]
    private Transform targetSphere;

    //[SerializeField]
    private Transform targetCamera;

    [SerializeField]
    private float speedToSphere = 5f;

   // [SerializeField]
    private float speedToCamera = 5f;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = this.targetSphere.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.SmoothDamp(this.transform.position, this.targetSphere.position, ref velocity, speedToSphere * Time.deltaTime);

        //this.transform.position = Vector3.MoveTowards(this.transform.position, this.targetCamera.position, speedToCamera * Time.deltaTime);
    }
}
