using UnityEngine;
using System.Collections;

public class deadTrigger : MonoBehaviour {
    

    // TO FIX: fix the trigger. currently not enabling halo correctly
    // TO FIX: fix the "get out of arena" bug.
    // TO ADD: instructions, menu, sound effects, "fucking up other player" mechanics.

   // bool isEnabled;
    int turnedOn = 2;

	// Use this for initialization
	void Start () {
       // isEnabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //on trigger enter, enable halo effect for bright things.
    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag != "dead")
        {
            //play a sound?
            {
                (gameObject.GetComponent("Halo") as Behaviour).enabled = true;
                StartCoroutine(stayOn());
                (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
                //isEnabled = !isEnabled;
            }
        }
    }

    IEnumerator stayOn()
    {
        yield return new WaitForSeconds(turnedOn);
    }
}   
