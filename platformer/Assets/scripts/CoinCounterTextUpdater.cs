using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinCounterTextUpdater : MonoBehaviour
{

    public CoinCounter coinCounter;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	    int coinCount = coinCounter.getCoinCount();

        Text text = GetComponent<Text>();

        text.text = coinCount.ToString();
	}
}
