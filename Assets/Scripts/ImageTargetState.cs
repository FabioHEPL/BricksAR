using UnityEngine;
using System.Collections;
using Vuforia;
using System;

public class ImageTargetState : MonoBehaviour, ITrackableEventHandler
{

    public event Action TrackingFound;
    public event Action TrackingLost;  

    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        Debug.Log(mTrackableBehaviour);
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }

    private void OnTrackingLost()
    {
        TrackingLost?.Invoke();
        
    }

    private void OnTrackingFound()
    {
        TrackingFound?.Invoke();
    }
}

