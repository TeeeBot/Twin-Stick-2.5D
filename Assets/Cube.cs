using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public float speed = 50.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (new Vector3 (0, 0, 1)* Time.deltaTime * speed); //A shortcut would be Vector3.forward
		}
		if (Input.GetKey (KeyCode.L)) {
			transform.Translate (Vector3.forward);
		}
	}
}
