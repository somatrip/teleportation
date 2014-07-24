using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour
{
    public GameObject ball;
    Vector2 force;
    public float push = 50f;

    //used for spawning
    Vector3 startPos;
    int limit = 5;

    // Use this for initialization
    void Start()
    {
        startPos = ball.transform.position;

        //initial force to work with. parameters chosen randomly from push
        force = new Vector2(Random.Range(-push, push), Random.Range(-push, push));
        ball.rigidbody2D.AddForce(force, ForceMode2D.Impulse);

        //spawn x number of balls
        StartCoroutine(SpawnBall());

    }

    // Update is called once per frame
    void Update()
    {

    }

    //spawn a ball, but wait one second before it shows up.
    IEnumerator SpawnBall()
    {
        yield return new WaitForSeconds(30);

        //spawn twenty balls and push them with some force on spawn
        for (int i = 0; i < limit; i++)
        {
            GameObject clonedball = Instantiate(ball, startPos, Quaternion.identity) as GameObject;
            clonedball.rigidbody2D.AddForce(force, ForceMode2D.Impulse);
            //add some particle or flare effects here
            yield return new WaitForSeconds(3);
        }
    }
}
