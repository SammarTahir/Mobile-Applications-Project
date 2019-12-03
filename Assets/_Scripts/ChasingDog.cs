using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class ChasingDog : MonoBehaviour {

	// This code is for AI movement 
	// This code is soruced at https://www.youtube.com/watch?v=jvtFUfJ6CP8&t=762s
	// This will be used for all enenmy AI
	public AIPath aiPath;
 
	// Update is called once per frame
    void Update(){
		// This is for flipping the dog image if the player is to the left or right of this object
		if (aiPath.desiredVelocity.x >= 0.01f){
			transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else if (aiPath.desiredVelocity.x <= 0.01f){
			transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}
}
