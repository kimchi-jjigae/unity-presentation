using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed;
    float lastShotTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector3(-1.0f, 0.0f, 0.0f) * speed;

        if(Random.value < 0.02f && Time.time - 0.5 > lastShotTime)
        {
            BroadcastMessage("fire", null, SendMessageOptions.DontRequireReceiver);
            lastShotTime = Time.time;
        }
	}

    void died()
    {
        Destroy(gameObject);
    }
}
