using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyButton : MonoBehaviour {
    public UnityEvent signalOnClick = new UnityEvent();
    public void _onClick()
    {
        this.signalOnClick.Invoke();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
