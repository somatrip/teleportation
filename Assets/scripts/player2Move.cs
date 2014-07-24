using UnityEngine;
using System.Collections;

public class player2Move : MonoBehaviour
{
    public GameObject deadplayer2;
    public int power = 50;
    public Vector2 speed = new Vector2(20, 20);

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

        //teleport and spawn dead body if left shift is pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //rigidbody2D.velocity += movement.normalized * power;
            //Debug.Log("Power!");
            Instantiate(deadplayer2, transform.position, Quaternion.identity);
            rigidbody2D.AddForce(movement.normalized * power, ForceMode2D.Impulse);
        }
    }
}
