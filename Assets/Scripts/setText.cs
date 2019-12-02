using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setText : MonoBehaviour {

	itemsPlayer plr;
	Text txt;
	// Use this for initialization
	void Start () {
		plr = GameObject.FindGameObjectWithTag("Player").GetComponent<itemsPlayer>();
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "X"+plr.getNotes();
	}
}
