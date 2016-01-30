using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int startHealth;
    int currentHealth;
	// Use this for initialization
	void Start () {
	    currentHealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void damage(int amount)
    {
        currentHealth = currentHealth - amount;

        if(currentHealth <= 0)
            BroadcastMessage("died", null, SendMessageOptions.DontRequireReceiver);
    }
}
