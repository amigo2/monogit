using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody2D.AddForce(new Vector2(-100, 0));
           

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(new Vector2(100, 0));

        }
	}
}
