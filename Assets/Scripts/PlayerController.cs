using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] private float speed; // Velocidad de mov
	private InputController input; // Variable que referenciara al componente del jugador
	private Transform trans; // Variable para el componente Transform

	private float x; // Horizontal
	private float y; // Vertical
	private Rigidbody2D rb;
	private Animator anim;
	private SpriteRenderer sRenderer;
	private int runingHash;
	// Use this for initialization
	
	void Start () {
		this.input = GetComponent<InputController>();
		this.trans = GetComponent<Transform>();
		this.rb = GetComponent<Rigidbody2D>();
		this.anim = GetComponent<Animator>();
		this.sRenderer = GetComponent<SpriteRenderer>();
		runingHash = Animator.StringToHash("isRunning");
	}
	
	void FixedUpdate() // En esta funcion se manejan las fisicas del juego
	{
	
		// ----------- Movimiento por fuerzas -------//
		//Vector2 force = new Vector2(x,y)*speed*Time.deltaTime;
		//this.rb.AddForce(force);

		// ------------ Movimiento por modificacion a la velocidad ---- //
		Vector2 force = new Vector2(x,y)*speed; 
		this.rb.velocity = force;
	}

	// Update is called once per frame
	void Update () 
	{ // En esta funcion se manjea la logica del juego
		this.x = input.x;
		this.y = input.y;
		
		if(x != 0 || y != 0)
		{
			SetxyAnim();	
		}
		else anim.SetBool(runingHash,false);

	}

	void SetxyAnim()
	{
		anim.SetBool(runingHash,true);
		anim.SetFloat("x",x);
		anim.SetFloat("y",y);
		FlipSprite();
		
	}

	void FlipSprite()
	{
		if(x<0 && Mathf.Abs(x) > Mathf.Abs(y))
		{
			sRenderer.flipX = true;
		}
		else
		{
			sRenderer.flipX = false;
		}
	}


}
