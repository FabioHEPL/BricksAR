using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public event Action Fulfilled;

    private Wall wall;

    private void Awake()
    {
        wall = FindObjectOfType<Wall>();              
    }

    private void OnEnable()
    {
        this.wall.BrickDestroyed += Wall_BrickDestroyed;
    }
    
    private void OnDisable()
    {
        this.wall.BrickDestroyed -= Wall_BrickDestroyed;
    }

    private void Wall_BrickDestroyed()
    {
        if (wall.Size <= 0)
        {
            Fulfilled?.Invoke();            
        }
    }
}
