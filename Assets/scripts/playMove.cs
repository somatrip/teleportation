using UnityEngine;
using System.Collections;

public class playMove : MonoBehaviour
{
    public GameObject deadplayer1;
    public int power = 50;
    public Vector2 speed = new Vector2(20, 20);

    Vector2 movement;

    //for screenshake purposes
    public screenShake shaker;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //control player movement; currently arrow keys
        float inputX = Input.GetAxis("Horizontal_P1");
        float inputY = Input.GetAxis("Vertical_P1");

        movement = new Vector2(speed.x * inputX,
                               speed.y * inputY);
    }

    void FixedUpdate()
    {
        //movement
        rigidbody2D.velocity = movement;

        //teleport and spawn dead body if 0 is pressed on numpad
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Instantiate(deadplayer1, transform.position, Quaternion.identity);
            rigidbody2D.AddForce(movement.normalized * power, ForceMode2D.Impulse);           
        }
    }

    //if the collider hits anything besides the ball, shake the screen.
    void OnTriggerEnter2D(Collider2D col)
    {
        //play a sound effect 

        if (col.gameObject.tag != "Ball")
        {
            shaker.shakeTimer += .1f;
        }
    }
}
