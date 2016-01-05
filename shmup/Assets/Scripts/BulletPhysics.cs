using UnityEngine;
using System.Collections;

public class BulletPhysics : MonoBehaviour {

    Rigidbody2D rigidbody2d;
    public float bulletSpeed;

	void Start () {
	    rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2(bulletSpeed, 0.0f);
	}
	
	void Update () {
	    if(transform.position.x < -10.0f ||
	       transform.position.x >  10.0f) {
            Destroy(gameObject);
        }
	}
}
