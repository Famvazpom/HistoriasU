using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
	Esta clase estara encargada de recibir el "input" del jugador de acuerdo a las teclas
	que esten activas.
*/ 
public class InputController : MonoBehaviour {
	[HideInInspector] public float x {get; private set;} // Valores posibles -1/0/1 || Eje horizontal
	[HideInInspector] public float y {get; private set;} // Valores posibles -1/0/1 || Eje vertical
	[HideInInspector] public bool ataque {get; private set;} // Variable para el estado de ataque
	[HideInInspector] public bool inventory {get; private set;} //Inventario
	[HideInInspector] public bool action {get; private set;} //Interaccion


	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		//Input.GetKey(KeyCode.F);
		this.ataque = Input.GetButtonDown("Attack");
		this.inventory = Input.GetButtonDown("Inventory");
		this.action = Input.GetButtonDown("Action");
		this.x = Input.GetAxis("Horizontal");
		this.y = Input.GetAxis("Vertical");
	}
}
