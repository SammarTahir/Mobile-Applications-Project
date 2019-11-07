using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	public int playerJumpPower = 1250;
	private float moveX;

	// Update is called once per frame
	void Update () {
		PlayerMove();

	}

	void PlayerMove(){
		// Controls
		// Moving player left or right
		moveX = Input.GetAxis("Horizontal");

		// Allowing the player to jump
		if (Input.GetButtonDown ("Jump")){
			Jump();
		}

		// Animations
		// Player Direction
		if (moveX < 0.0f && facingRight == false){
			FlipPlayer();
		} else if (moveX > 0.0f && facingRight == true){
			FlipPlayer();
		}
		// Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, 
			gameObject.GetComponent<Rigidbody2D>().velocity.y);

	}

	void Jump(){
		// Jumping code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
	}

	void FlipPlayer(){
		// Changing the way the player is facing
		facingRight = !facingRight;
		// LocalScale is the scale of the player
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
	
}
