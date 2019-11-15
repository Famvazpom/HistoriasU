using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene_on_click : MonoBehaviour{

    public void LoadbyName(string sceneName){
         SceneManager.LoadScene(sceneName);
    }
}
