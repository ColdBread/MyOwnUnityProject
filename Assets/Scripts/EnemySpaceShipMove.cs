﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceShipMove : MonoBehaviour {
     float downSpeed;

     float leftRightSpeed;
     float radius;

    Rigidbody2D myBody = null;

	// Use this for initialization
	void Start () {
        myBody = this.GetComponent<Rigidbody2D>();
        downSpeed = LevelController.current.levelSpeed;
        leftRightSpeed = Random.Range(1.0f, 5.0f);
        radius = Random.Range(0.5f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Vector2 vel = myBody.velocity;
        vel.y = -downSpeed;
        vel.x = Mathf.Sin(Time.time*leftRightSpeed) * radius;
        myBody.velocity = vel;
 
    }
}
