using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringArrow : MonoBehaviour {

public GameObject projectile;
public Vector2 velocity;
bool canShoot = true;
public Vector2 offset = new Vector2(0.4f, 0.1f);



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(){
			Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
		}
			

	}
}
