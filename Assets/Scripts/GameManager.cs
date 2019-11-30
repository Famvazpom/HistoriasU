using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	public Transform playerSpawn;
	public GameObject player;
	public string playerTag;
	// Use this for initialization
	
	void Start () {
		player = GameObject.FindGameObjectWithTag(playerTag);
		player.transform.position = playerSpawn.position;
	}
	
	// Update is called once per frame
}
