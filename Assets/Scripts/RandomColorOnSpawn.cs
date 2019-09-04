using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RandomColorOnSpawn : MonoBehaviour
{
    Material _material;

    void Awake()
    {
        _material = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Color randomColor = Random.ColorHSV(0, 1, 0.75f, 0.75f, 0.75f, 0.75f);
        _material.SetColor("_Color", randomColor);
    }
}
