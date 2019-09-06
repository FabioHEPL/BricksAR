using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInfo : MonoBehaviour
{
    [SerializeField]
    private ImageTargetState targetState;

    [SerializeField]
    private Canvas canvas;

    private void OnEnable()
    {
        this.targetState.TrackingFound += TargetState_TrackingFound;
        this.targetState.TrackingLost += TargetState_TrackingLost;
    }

    private void OnDisable()
    {
        this.targetState.TrackingFound -= TargetState_TrackingFound;
        this.targetState.TrackingLost -= TargetState_TrackingLost;
    }

    private void TargetState_TrackingFound()
    {
        this.canvas.enabled = false;
    }

    private void TargetState_TrackingLost()
    {
        this.canvas.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
