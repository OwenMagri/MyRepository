using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3GoalPost1 : MonoBehaviour {

    public static int score2 = 0;
    public Text PlayerScore;
    public int maxHits;

    // Use this for initialization
    void Start () {
        maxHits = 15;
        PlayerScore.text = "0";

    }
	
	// Update is called once per frame
	void Update () {
        if (score2 >= maxHits)
        {
            SceneManager.LoadScene("End_Scene");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        score2 = score2 + 3;
        PlayerScore.text = "" + score2;

    }
}
