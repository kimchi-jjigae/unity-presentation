using UnityEngine;
using System.Collections;

public class CoinCollectible : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        CoinCounter counter = other.gameObject.GetComponent<CoinCounter>();

        if(counter != null)
        {
            counter.increment();
        }

        Destroy(gameObject);
    }
}
