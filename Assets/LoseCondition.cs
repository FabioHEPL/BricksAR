using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public event Action Fulfilled;

    private LoseZone loseZone;

    private void Awake()
    {
        loseZone = FindObjectOfType<LoseZone>();
    }

    private void OnEnable()
    {
        loseZone.Triggered += LoseZone_Triggered;
    }

    private void LoseZone_Triggered(Collider obj)
    {
        if (obj.gameObject.CompareTag("Ball"))
            Fulfilled?.Invoke();
    }
}
