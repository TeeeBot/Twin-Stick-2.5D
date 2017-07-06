using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyKeyFrame testKey = new MyKeyFrame(1.0f, Vector3.up, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


//A struct is stored as a value type rather than a reference
public struct MyKeyFrame {
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	//The constructor has the same name as the class
	public MyKeyFrame (float aTime, Vector3 aPosition, Quaternion aRotation){ //THE CONSTRUCTOR
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;

	}

}


//Time- Float
//pos- Vector 3
//rot - quaternion