using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, 0, speed * 1); 
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, 0, speed * -1);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed * 1, 0, 0);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(speed * -1, 0, 0);
        }
    }
}
