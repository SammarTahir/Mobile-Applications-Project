using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnergyBall : MonoBehaviour {

	 public float speed =20f;
    public int damage = 25;
    float moveSpeed = 7f;

    Rigidbody2D rb;
    PlayerMovement target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        rb.velocity = transform.right * speed;
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy (gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.name.Equals ("player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy (gameObject);
        }
    }
}
