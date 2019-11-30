using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private string playerTag;
	private float action;
	public void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag == playerTag)
		{
			Debug.Log("Abrir cofre");
		}
	}
}
