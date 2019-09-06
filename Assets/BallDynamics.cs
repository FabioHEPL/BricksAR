using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDynamics : MonoBehaviour
{
    [SerializeField]
    private ImageTargetState targetState;



    private void Awake()
    {
        Debug.Log("awake...");

        this.targetState.TrackingFound += TargetState_TrackingFound;
        this.targetState.TrackingLost += TargetState_TrackingLost;
        this.gameObject.SetActive(false);

    }

    private void OnDisable()
    {

    }


    private void TargetState_TrackingFound()
    {
        Debug.Log("Activating...");
        this.gameObject.SetActive(true);
    }

    private void TargetState_TrackingLost()
    {
        this.gameObject.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Debug.Log("destroy...");
        this.targetState.TrackingFound -= TargetState_TrackingFound;
        this.targetState.TrackingLost -= TargetState_TrackingLost;
    }
}
