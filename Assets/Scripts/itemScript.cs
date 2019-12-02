using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour {

	[SerializeField] public string playerstr;

	[SerializeField] public string item;
	public itemsPlayer player;


	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<itemsPlayer>();

		if(player.CheckItem(item))
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == playerstr)
		{
			player.GetItem(item);
			Destroy(this.gameObject);
		}		
	}

}
