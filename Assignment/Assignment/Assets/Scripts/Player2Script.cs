using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 10) - 5;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePosInUnits , this.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -5f, 5f);


        this.transform.position = newPaddlePos;
    }
}
