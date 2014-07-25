using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    public Camera mainCam;

	// Use this for initialization
	void Start () {

        cam2.enabled = cam1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void cameraSwap(Collider2D deadPlayer)
    {
        //swap to the relevant camera
        if (deadPlayer.tag == "1player")
        {
            mainCam.enabled = false;
            cam1.enabled = true;
        }
        else
        {
            mainCam.enabled = false;
            cam2.enabled = true;
        }
        //pause the music
        //enable GUI words showing victory
    }
}