using System;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    public Vector3 offset;
    void Update()
    {
        transform.position = PlayerTransform.position + offset;
    }
}
