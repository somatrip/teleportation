using UnityEngine;
using System.Collections;

public class ballTrigger : MonoBehaviour {

    Vector2 center;
    public float forcePush = 5; //to be used for the "slight push" when bouncing off other objects. 

    //for game ending purposes
    public cameraControl camControl;
    public GameObject camController;

	// Use this for initialization
	void Start () {
        camControl = camController.GetComponent<cameraControl>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D thing)
    {
        //the direction with which to push slightly. original direction rotated 45 degrees left or right
        center = Quaternion.Euler(0f, 0f, 45f) * rigidbody2D.velocity.normalized * forcePush;

            //destroy player
            if (thing.gameObject.tag == "1player" || thing.gameObject.tag == "2player")
            {
                Time.timeScale = 0;
                StartCoroutine(pause()); 
                camControl.cameraSwap(thing);
                //have some camera shake or camera zoom and text saying who wins here
            }

            //bounce a different direction
            else
            {
                //add a slight force either left or right
                forcePush *= -1;
                rigidbody2D.AddForce(center, ForceMode2D.Impulse);
            }
        }   

    IEnumerator pause()
    {
        yield return new WaitForSeconds(1);
    }
}