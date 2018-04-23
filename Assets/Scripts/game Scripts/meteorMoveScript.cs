using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


    }
	
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.4f);
        this.gameObject.GetComponent<Rigidbody2D>().transform.Translate(new Vector2(-3.0f * Time.deltaTime, 0.0f));

    }

    // Update is called once per frame
    void Update () {

        StartCoroutine(wait());
    }

}
