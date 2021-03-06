﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //designer variables
    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Get Axis Input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);
        float upDown = Input.GetAxis(verticalAxis);

        //Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        //Make direction vector length 1
        direction = direction.normalized;

        //Calculate Velocity
        Vector2 velocity = direction * speed;

        //give the velocity to our rigid body
        physicsBody.velocity = velocity;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //Check if the object we bumped into is an enemy
        if (collision.collider.GetComponent<Enemy>())
        {
            //Die
            Destroy(gameObject);
        }
    }
}
