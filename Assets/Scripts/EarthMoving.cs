using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMoving : MonoBehaviour {
    Rigidbody2D myBody;

	// Use this for initialization
	void Start () {
        myBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (transform.position.y < -5.0f)
        {
            Vector2 vel = myBody.velocity;
            vel.y = 0.2f;
            myBody.velocity = vel;
        }
        else
        {
            Vector2 vel = myBody.velocity;
            vel.y = 0;
            myBody.velocity = vel;
        }
    }
}
