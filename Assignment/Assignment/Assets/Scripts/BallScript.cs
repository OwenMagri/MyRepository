using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Vector3 ballPos;
    bool gameStart = false;

    // Use this for initialization
    void Start () {
        ballPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {

        if (gameStart == false)
        {
            transform.position = ballPos;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 10f);
        }
    }

    //restarts the ball position
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GoalPost1")
        {
            gameStart = false;
        }
        if (collision.gameObject.name == "GoalPost2")
        {
            gameStart = false;
        }

    }
}
