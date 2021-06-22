using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float distance = 0.75f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + new Vector3(0, distance, -distance);
    }
}
