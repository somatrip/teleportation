var camera1 : Camera;

var camera2 : Camera;
var wipeTime = 2.0;
private var inProgress = false;
private var swap = false;

function Update () {
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
        StartCoroutine(DoWipe(TransitionType.Up));
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow)) {
        StartCoroutine(DoWipe(TransitionType.Down));
    }
    else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        StartCoroutine(DoWipe(TransitionType.Left));
    } 
    else if (Input.GetKeyDown(KeyCode.RightArrow)) {
        StartCoroutine(DoWipe(TransitionType.Right));
    }
}

function DoWipe (transitionType : TransitionType) {
	Debug.Log("this is working");
    if (inProgress) return;
    inProgress = true;
   
    swap = !swap;
    yield ScreenWipe.use.SquishWipe (swap? camera1 : camera2, swap? camera2 : camera1, wipeTime, transitionType);
   
    inProgress = false;
}