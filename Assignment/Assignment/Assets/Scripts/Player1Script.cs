using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y += 20.0f * Time.deltaTime;
            position.y = Mathf.Clamp(position.y, -5f, 5f);
            this.transform.position = position;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y -= 20.0f * Time.deltaTime;
            position.y = Mathf.Clamp(position.y, -5f, 5f);
            this.transform.position = position;
        }

    }
}
