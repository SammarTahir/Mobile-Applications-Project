using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoss : MonoBehaviour {

	private float timeBtwAttack;
	public float startTimeBtwAttack;

	public Transform attackPos;
	public LayerMask whatIsEnemies;
	public float attackRange;
	public int damage;

	public GameObject swordEffect;
	
	// Update is called once per frame
	void Update () {
		if(timeBtwAttack <= 0){
			// Then you can attack the enemy
			if(Input.GetKey(KeyCode.UpArrow)){
				Instantiate(swordEffect, transform.position, Quaternion.identity);
				// All enenies within this circle will be hit by the sword
				Collider2D[] eneniesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
				for (int i = 0; i < eneniesToDamage.Length; i++) {
					eneniesToDamage[i].GetComponent<FinalBoss>().TakeDamage(damage);

				}
			}

			timeBtwAttack = startTimeBtwAttack;
		} else {
			timeBtwAttack -= Time.deltaTime;
		}
	}

	void onDrawGizmoSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(attackPos.position, attackRange);

	}
}
