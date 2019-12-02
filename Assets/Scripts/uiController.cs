using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour {

    Camera m_MainCamera;
	Canvas cv;
	// Use this for initialization
	void Start () {
		m_MainCamera = Camera.main;
		cv = GetComponent<Canvas>();
		cv.worldCamera = Camera.main;
	}
	
}
