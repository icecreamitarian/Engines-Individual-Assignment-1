using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovement : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        gameObject.transform.position = new Vector2
           (transform.position.x + (horizontal * speed),
           transform.position.y + (vertical * speed));
    }
}

// Code loosely based on code from https://www.tutorialspoint.com/unity/unity_basic_movement_scripting.htm.