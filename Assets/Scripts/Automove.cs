using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove : MonoBehaviour
{
    [Range(-5, 5)]
    public float Speed_X;
    [Range(-5, 5)]
    public float Speed_Y;

    void Update()
    {
        this.transform.Translate(new Vector2(Speed_X, Speed_Y) * Time.deltaTime);
    }
}
