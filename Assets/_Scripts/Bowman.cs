using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bowman : MonoBehaviour {
// use later for other stuff
    // add the collider stuff, to detect if a bullet hits
    // detect the collisiion
    // destroy the bullet prefab, then this prefab

    //enemy movement variables
  
    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;  
    public Transform player;

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

   void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Bowman enemy = hitInfo.GetComponent<Bowman>();
        
        if (hitInfo.gameObject.name.Equals ("player")) {
            Destroy (gameObject);
        }
    }

}