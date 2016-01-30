using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector3(-1, 0, 0) * speed;

        if(Random.value < 0.02f)
            BroadcastMessage("fire", null, SendMessageOptions.DontRequireReceiver);
	}

    void died()
    {
        Destroy(gameObject);
    }
}
