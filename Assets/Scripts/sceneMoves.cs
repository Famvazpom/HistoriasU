using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMoves : MonoBehaviour {

	[SerializeField] public string ScenetoLoad;
	[SerializeField] public Vector3 nextPos;


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player") 
		{	
			SceneManager.LoadScene(ScenetoLoad);
			other.transform.position= nextPos;
		}
	}
}
