using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reticleSwitchColor : MonoBehaviour {

	 
    [SerializeField] private SpriteRenderer spriteToColor;

    //try an onTriggerStay, the enter doesnt seem to be working
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "meteor")
        {
            spriteToColor.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "meteor")
        {
            spriteToColor.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f);

        }
    }
}
