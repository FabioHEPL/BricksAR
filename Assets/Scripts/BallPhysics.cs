using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{

    [SerializeField]
    private float speed = 100.0F;

    private Rigidbody rg;

    void Awake()
    {
        rg = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        rg.AddRelativeForce(transform.forward * speed, ForceMode.Force);
    }

    private void Start()
    {
        
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
 
    }

    private void OnCollisionEnter(Collision collision)
    {

        //if(collision.gameObject.CompareTag("Brick"))
        //    Destroy(collision.gameObject);

    }

}
