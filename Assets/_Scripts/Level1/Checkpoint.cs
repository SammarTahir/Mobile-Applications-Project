using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

  void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.name.Equals ("player")) {
            SceneManager.LoadScene("BossLevel1");
            Destroy (gameObject);
        }
    }
}
