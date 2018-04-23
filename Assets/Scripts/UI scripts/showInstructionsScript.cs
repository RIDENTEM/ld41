using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showInstructionsScript : MonoBehaviour {


    [SerializeField] private GameObject instructionsPanel;
    [SerializeField] private GameObject menuPanel;


    public void onInstructionsButtonPressed()
    {
        
        menuPanel.SetActive(false);
        instructionsPanel.SetActive(true);
    }

}
