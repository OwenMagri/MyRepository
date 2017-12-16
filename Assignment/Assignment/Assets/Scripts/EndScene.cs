using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour {

    public Text FinalScore1;
    public Text FinalScore2;
    public Text Winner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int player1total = GoalPost1Script.score2 + Level2GoalPost1.score2 + Level3GoalPost1.score2;
        int player2total = GoalPost2Script.score1 + Level2GoalPost2.score1 + Level3GoalPost2.score1;

        FinalScore1.text = player1total + "";
        FinalScore2.text = player2total + "";

        if(player1total > player2total)
        {
            Winner.text = "Winner: Player 2";
        }
        else if(player2total > player1total)
        {
            Winner.text = "Winner: Player 1";
        }
        else
        {
            Winner.text = "It's a tie!";
        }
        
	}

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Menu");
    }
}
