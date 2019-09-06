using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayZone : MonoBehaviour
{
    [SerializeField]
    private GameObject avatar;

    [SerializeField]
    private Vector3 scale;

    [SerializeField]
    private float factor = 1f;

    [SerializeField]
    private float distance = 1f;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private bool locked = false;

    // Start is called before the first frame update
    void Start()
    {
        //this.avatar.transform.localScale = this.scale;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.locked)
        {
            this.distance = Vector3.Distance(this.avatar.transform.position, this.mainCamera.transform.position);
            this.scale = Vector3.one * distance * factor;
            this.avatar.transform.localScale = this.scale;
        }

        if (Input.GetMouseButtonDown(0))
        {
            this.locked = true;
        }
    }

    private void OnValidate()
    {
        //this.avatar.transform.localScale = this.scale;
    }
}
