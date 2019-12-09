using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.name.Equals ("player")) {
            SceneManager.LoadScene("BossLevel2");
            Destroy (gameObject);
        }
    }
}
