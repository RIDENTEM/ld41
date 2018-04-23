using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeReticleColor : MonoBehaviour {

    [SerializeField] private SpriteRenderer spriteToColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<RawImage>().color = new Color(1.0f, 0.0f, 0.0f);
	}
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "meteor")
        {
            Debug.Log("Hit the meteor");
            this.gameObject.GetComponent<RawImage>().color = new Color(0.0f, 1.0f, 0.0f);
            
        }
    }

}
