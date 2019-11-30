using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour {

	public static dontDestroy playerInstance = null;
	// Use this for initialization
	void Start () {
		
		if(playerInstance == null)
		{		
			stay();
		}
		else
		{
			Destroy(this.gameObject);
		}

	}
	
	void stay()
	{
		DontDestroyOnLoad(this);
		playerInstance = this;
	}

	// Update is called once per frame

}
