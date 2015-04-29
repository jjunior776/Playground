using UnityEngine;
using System.Collections;

public class movementThirdPerson : MonoBehaviour {

	public float moveSpeed = 0.1f;
	public float rotateSpeed = 10f;

	
	void FixedUpdate () {
		
		float movex = Input.GetAxis ("Horizontal");
		float movey = Input.GetAxis ("Vertical");

		gameObject.transform.Translate (0, 0, movey * moveSpeed);
		gameObject.transform.Rotate (0, movex * rotateSpeed, 0);
		
		
	}
}
