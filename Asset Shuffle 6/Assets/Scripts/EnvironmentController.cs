using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public float baseSpeed = 2f;
    public void Move(Transform transform, Vector3 direction, Vector3 position)
    {
        // transform.position += new Vector3(-position.x, -position.y, -position.z);
        Vector3 modified = new Vector3(direction.z, 0, -direction.x);
        transform.eulerAngles += modified * baseSpeed;
    }
}
