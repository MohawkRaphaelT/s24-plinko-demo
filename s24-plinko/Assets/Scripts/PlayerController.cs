using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Our variables, public to expose in Unity editor
    public float speed = 5;

    // Update which runs every frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        float displacement = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            movement.x -= displacement;

        if (Input.GetKey(KeyCode.D))
            movement.x += displacement;

        transform.position += movement;
    }
}
