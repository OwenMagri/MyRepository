using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;

	// Use this for initialization
	void Start () {

        if(instance != null)
        {
            Destroy(gameObject);
        }
        else //instance is still null so this is the first music player
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
