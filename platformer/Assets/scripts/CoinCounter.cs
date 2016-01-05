using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour
{

    int coinCount = 0;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void increment()
    {
        ++coinCount;
    }

    public int getCoinCount()
    {
        return coinCount;
    }   
}
