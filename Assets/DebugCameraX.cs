using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCameraX : MonoBehaviour
{

    [SerializeField]
    private GameObject cameraMain;

    private Text mytext;

    private void Awake()
    {
        mytext = GetComponent<Text>();
    }

    void Start()
    {
            
    }

    void Update()
    {

        mytext.text = $"Debug camera X : {cameraMain.transform.position.x.ToString("0.00")}";

    }
}
