using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public Transform bullet;

    Rigidbody2D rigidbody2d;
    public float shipSpeed;

    Vector2 screenBounds;

	void Start() {
	    rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2(shipSpeed, 0.0f);
	}

	void Update () {
	    if(transform.position.x < -10.0f ||
	       transform.position.x >  10.0f) {
            Destroy(gameObject);
        }
        if(Random.value < 0.05f) {
            ShootBullet();
        }
	}

    void ShootBullet() {
        Vector3 yOffset = new Vector3(0.0f, 0.5f, 0.0f);
        Instantiate(bullet, transform.position - yOffset, transform.rotation);
        Instantiate(bullet, transform.position + yOffset, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
