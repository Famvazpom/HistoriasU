using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour {

	// Use this for initialization
	private itemsPlayer plr;

	[SerializeField] private string playerTag;

	void Start()
	{
		plr = GameObject.FindGameObjectWithTag("Player").GetComponent<itemsPlayer>();

	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Enter");
		if(other.gameObject.tag == playerTag && plr.CheckNotes())
		{
			Destroy(this.gameObject);
		}
	}
}
