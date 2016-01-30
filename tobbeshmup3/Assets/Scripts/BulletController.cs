using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public Vector3 direction;
    public float speed;

	// Use this for initialization
	void Start () {
	    Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity = direction * speed;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Health health = other.GetComponent<Health>();

        health.damage(1);

        Destroy(gameObject);
    }
}
