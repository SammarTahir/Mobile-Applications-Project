using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public int health;
	public bool dead;

	// Use this for initialization
	void Start () {
		dead = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -6){
			dead = true;
		}
		if (dead == true) {
			StartCoroutine ("Die");
		}
	}

	IEnumerator Die(){
		SceneManager.LoadScene("Level1");
		yield return null;
		
	}

}
