using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPopUp : MonoBehaviour {

    public GameObject scoreLabel, highLabel;

    UILabel labelScore, labelHigh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setStats(LocalStats stats)
    {
        labelScore = scoreLabel.GetComponent<UILabel>();
        labelHigh = highLabel.GetComponent<UILabel>();
        labelScore.text = "Score: " + stats.score;
        GeneralStats statsGen = GeneralStats.fromStorage();
        labelHigh.text = "Previous HighScore: " + statsGen.highScore;
    }

    public void onBlackClick()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("MainMenu");
    }
}
