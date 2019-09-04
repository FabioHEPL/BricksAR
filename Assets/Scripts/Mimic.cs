using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position
            = new Vector3(this._gameObject.transform.position.x,
            this.transform.position.y,
            this.transform.position.z);
        
    }
}
