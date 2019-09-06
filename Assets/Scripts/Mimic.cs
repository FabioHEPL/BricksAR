using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Mimic : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private ImageTargetState targetState;

    [SerializeField]
    private List<Renderer> _renderers;

    [SerializeField]
    private bool mimicTransform = true;
    private Vector3 currentVelocity = Vector3.zero;

    [SerializeField]
    private float smoothTime = 5f;


    [SerializeField]
    private float minCameraX = -5;

    [SerializeField]
    private float maxCameraX = 5f;

    [SerializeField]
    private Canvas canvas;


    private void Awake()
    {
        //this.targetState = this._gameObject.GetComponent<ImageTargetState>();

        TransposeCameraPositionX();

        DisableRenderers();
        Debug.Log(this.targetState);
    }


    private void DisableRenderers()
    {
        _renderers.ForEach(r => r.enabled = false);

    }

    private void EnableRenderers()
    {
        _renderers.ForEach(r => r.enabled = true);
    }

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

    private void TargetState_TrackingLost()
    {    
        DisableRenderers();
    }

    private void TargetState_TrackingFound()
    {
        EnableRenderers();
    }

    // Start is called before the first frame update
    void Start()
    {
        //if (false && this.mimicTransform)
        //{
        //    this.transform.position = this._gameObject.transform.position;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (this.mimicTransform)
        {

            this.transform.position =
                Vector3.SmoothDamp(                   
                    
                    this.transform.position,
                    new Vector3(TransposeCameraPositionX(),
                    this.transform.position.y,
                    this.transform.position.z),
                    ref currentVelocity,
                    smoothTime * Time.deltaTime);


        }
        
    }


    public float TransposeCameraPositionX()
    {
        float cameraPositionRatio = Mathf.InverseLerp(this.minCameraX, this.maxCameraX, this.mainCamera.transform.position.x);

        float leftX, rightX = 0f;
        GetLeftRightX(out leftX, out rightX);
       // Debug.Log($"Left X : {leftX} | Right X : {rightX}");
       // Debug.Log($"Camera posX : {this.mainCamera.transform.position.x} | Camera position ratio : {cameraPositionRatio}");

        float cameraPositionXTransposed = Mathf.Lerp(leftX, rightX, cameraPositionRatio);

        //Debug.Log($"Camera position X transposed : {cameraPositionXTransposed}");

        return cameraPositionXTransposed;
    }



    private void GetLeftRightX(out float leftX, out float rightX)
    {
        RectTransform rectTransform = canvas.GetComponent<RectTransform>();

        Vector3[] v = new Vector3[4];
        rectTransform.GetWorldCorners(v);

        leftX = v[0].x;
        rightX = v[3].x;
    }
}
