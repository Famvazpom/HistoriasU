using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMannager : MonoBehaviour {

	// Use this for initialization
	public void Play()
	{
		SceneManager.LoadScene("Afueras");
	}

	public void Exit()
	{
		#if (UNITY_EDITOR)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        #else
        {
            Application.Quit ();
        }
        #endif
	}
}
