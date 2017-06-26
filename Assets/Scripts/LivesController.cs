using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour {

    public static LivesController current;
    int lives = 3;

	// Use this for initialization
	void Start () {
        current = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void removeLife()
    {
        lives--;
        UILabel label = this.GetComponentInChildren<UILabel>();
        label.text = "x " + lives;
    }
}
