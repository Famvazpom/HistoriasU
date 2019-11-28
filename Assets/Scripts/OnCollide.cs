using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollide : MonoBehaviour {

	[SerializeField] public string ScenetoLoad;


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player") SceneManager.LoadScene(ScenetoLoad);
	}
}
