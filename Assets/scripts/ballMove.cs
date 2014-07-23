using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour {

    public Vector2 force;
    Vector2 position; 


	// Use this for initialization
	void Start () {

        force = new Vector2(50, 50);
        rigidbody2D.AddForce(force, ForceMode2D.Impulse);
        position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator SpawnBall()
    {

        yield return new WaitForSeconds(1);
    }
}
