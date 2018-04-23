using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeReticleColor : MonoBehaviour {

    [SerializeField] private SpriteRenderer spriteToColor;
	 
	// Update is called once per frame
	void Update () {
        spriteToColor.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f);
	}
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "meteor")
        {
            Debug.Log("Hit the meteor");
            spriteToColor.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f);
            
        }
    }
    
    //try an onTriggerStay, the enter doesnt seem to be working

}
