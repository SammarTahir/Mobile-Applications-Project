using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bowman : MonoBehaviour {
    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;  
    public Transform player;
    public int health;

    public GameObject bloodEffect;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    } 

    void Update(){
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }else{
            timeBtwShots -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damage){
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    } 

   void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Bowman enemy = hitInfo.GetComponent<Bowman>();
        
        if (hitInfo.gameObject.name.Equals ("player")) {
            Destroy (gameObject);
        }
    }

}