using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraController : MonoBehaviour {

	// Use this for initialization
	public CinemachineVirtualCamera camera;
	public GameObject player;
	
	void Start () {
		camera = GetComponent<CinemachineVirtualCamera>();
		player = GameObject.FindGameObjectWithTag("Player");
		camera.Follow = player.transform;
	}
	
	// Update is called once per frame
}
