using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2GoalPost2 : MonoBehaviour {

    public static int score1 = 0;
    public Text PlayerScore;
    public int maxHits;

    // Use this for initialization
    void Start () {
        maxHits = 5;
        PlayerScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (score1 >= maxHits)
        {
            SceneManager.LoadScene("Level_3");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        score1++;
        PlayerScore.text = "" + score1;

    }
}
