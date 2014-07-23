using UnityEngine;
using System.Collections;

public class player2Move : MonoBehaviour
{

    public int power = 10;
    public Vector2 speed = new Vector2(10, 10);

    Vector2 movement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //control player movement; currently WASD
        float inputX = Input.GetAxis("Horizontal_P2");
        float inputY = Input.GetAxis("Vertical_P2");

        movement = new Vector2(speed.x * inputX,
                               speed.y * inputY);

    }


    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}
