using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToMainMenu : MonoBehaviour {


    public void onMenuButtonHit()
    {
        SceneManager.LoadScene("mainMenu");
    }


}
