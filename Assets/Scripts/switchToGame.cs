using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class switchToGame : MonoBehaviour {

	 
    public void onPlayButtonClick()
    {
        //Since main menu will be 0, I figure main game will be 1
        SceneManager.LoadScene(1);
    }

	 
}
