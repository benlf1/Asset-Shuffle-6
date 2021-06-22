using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private PlayerHost host;
    public EnvironmentController environment;
    public GameObject player;

    void Awake()
    {
        // host = GetComponent<PlayerHost>();
    }

    void FixedUpdate()
    {
        // host.movement.Move(host.body, GetMovementInput());
        environment.Move(environment.gameObject.transform, GetMovementInput(), player.transform.position);
        Debug.Log(player.transform.position);
        // player.transform.position = new Vector3(0, 0, 0);
    }

    private Vector3 GetMovementInput()
    {
        /*  
         *  Vector3 Movement works as follows (assuming facing forward):
         *  x: Left/Right           (A/D)
         *  y: Up/Down
         *  z: Forward/Backward     (W/S)
         */ 
        return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    }
}
