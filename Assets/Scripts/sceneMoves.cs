using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMoves : MonoBehaviour {

	[SerializeField] public string ScenetoLoad;
	[SerializeField] public Vector3 nextPos;
	[SerializeField] private string requisito;
	[SerializeField] private bool hasReq;
	private itemsPlayer ply;

	void Start()
	{
		ply =  GameObject.FindGameObjectWithTag("Player").GetComponent<itemsPlayer>();

	}


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player") 
		{	
			if(hasReq)
			{
				if( ply.CheckItem(requisito) )
				{
					LoadLevel(other);
				}
			}
			else
			{
				LoadLevel(other);
			}

		}
	}

	private void LoadLevel(Collider2D other)
	{
		SceneManager.LoadScene(ScenetoLoad);
		other.transform.position= nextPos;
	}

}
