using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPepe : MonoBehaviour {


	itemsPlayer plr;
	// Use this for initialization
	void Start () {
		plr = GameObject.FindGameObjectWithTag("Player").GetComponent<itemsPlayer>();
		CheckReq();
	}
	

	private void CheckReq()
	{
		if(plr.hasAll())
		{
			this.gameObject.SetActive(true);
		}
		else
		{
			this.gameObject.SetActive(false);
			
		}
	}
	// Update is called once per frame
	void Update () {
		CheckReq();
	}
}
