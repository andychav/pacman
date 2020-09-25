using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private new Rigidbody2D rigidbody;

    private new Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        this.transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 movement = rigidbody.position;

        if (Input.GetKey("up"))
        {
            movement.y++;
        }

        if (Input.GetKey("down"))
        {
            movement.y--;
        }

        if (Input.GetKey("right"))
        {
            movement.x++;
        }

        if (Input.GetKey("left"))
        {
            movement.x--;
        }

        //MovePosition literally moves the body to the position im passing which is bound to the movement 

        rigidbody.MovePosition(movement * speed);
    }
}
