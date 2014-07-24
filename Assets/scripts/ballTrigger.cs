using UnityEngine;
using System.Collections;

public class ballTrigger : MonoBehaviour {

    Vector2 center;
    public float forcePush = 5; //to be used for the "slight push" when bouncing off other objects. 
    bool isLeft;

	// Use this for initialization
	void Start () {
        isLeft = true;
 
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider thing)
    {
        //the direction with which to push slightly. original direction rotated 45 degrees left or right
        center = Quaternion.Euler(0f, 0f, 45f) * rigidbody2D.velocity.normalized * forcePush;

        //since the collider has a ball inside, the ball always triggers
       // if (thing.gameObject.tag != "Ball")
        {
            //destroy player
            if (thing.gameObject.tag == "Player")
            {
                Debug.Log("tango down");
                Destroy(thing.gameObject);
                //have some camera shake or camera zoom and text saying who wins here
            }

            //bounce a different direction
            else
            {
                Debug.Log("false alarm");
                //add a slight force either left or right
                if (isLeft)
                {
                    forcePush *= -1;
                    isLeft = false;
                }

                else
                {
                    forcePush *= -1;
                    isLeft = true;
                }

                rigidbody2D.AddForce(center, ForceMode2D.Impulse);
            }
        }
            

    }
}
