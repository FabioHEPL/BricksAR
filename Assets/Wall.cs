using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public event Action BrickDestroyed;

    public int Size => this.bricks.Count;

    private List<Brick> bricks;

    private void Awake()
    {
        bricks = this.GetComponentsInChildren<Brick>().ToList();
    }

    private void OnEnable()
    {
        bricks.ForEach(brick => brick.Destroy += Brick_Destroy);
    }

    private void OnDisable()
    {
        bricks.ForEach(brick => brick.Destroy -= Brick_Destroy);
    }

    private void Brick_Destroy(object sender, EventArgs args)
    {
        Brick brick = (Brick)sender;
        this.bricks.Remove(brick);

        BrickDestroyed?.Invoke();
    }
}
