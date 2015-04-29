using UnityEngine;
using System.Collections;

public class thirdPerson : MonoBehaviour {

	public Transform positionForCamera;
	public Transform positionTarget;

	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = positionForCamera.position;
		gameObject.transform.LookAt (positionTarget);
	}
}

