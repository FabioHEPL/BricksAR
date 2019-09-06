using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public new event System.EventHandler Destroy;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Object.Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        Destroy?.Invoke(this, new System.EventArgs());
    }
}
