using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    public float baseSpeed = 5f;

    public void Move(Rigidbody body, Vector3 direction, float force)
    {
        body.AddForce(direction.normalized * force);
    }

    public void Move(Rigidbody body, Vector3 direction)
    {
        Move(body, direction, baseSpeed);
    }
}
