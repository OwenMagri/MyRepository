﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public int maxHits;
    public AudioClip crack;

    int timesHit;

	// Use this for initialization
	void Start () {

        //crack = Resources.Load("crack", typeof(AudioClip)) as AudioClip;
        timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);

        if (timesHit >= maxHits)
        {
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            Destroy(gameObject);
        }
    }
}
