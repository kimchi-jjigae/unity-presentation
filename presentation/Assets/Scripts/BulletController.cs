using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public Vector3 direction;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = direction * speed;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Health health = other.GetComponent<Health>();

        health.damage(1);

        Destroy(gameObject);
    }
}
