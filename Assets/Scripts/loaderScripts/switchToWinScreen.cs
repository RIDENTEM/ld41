using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToWinScreen : MonoBehaviour {

    public void onWin()
    {
        SceneManager.LoadScene("winScreen");
    }

}
