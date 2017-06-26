using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {
    public static ScoreController current;
	// Use this for initialization
	void Start () {
        current = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateScore(int score)
    {
        string n_score = score.ToString();
        while (n_score.Length < 5)
        {
            n_score = "0" + n_score;
        }
        UILabel label = this.GetComponentInChildren<UILabel>();
        label.text = "Score: " +n_score;
    }
}
