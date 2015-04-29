using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float maxSpeed = 100f;			
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		
		float movex = Input.GetAxis ("Horizontal");
		float movey = Input.GetAxis ("Vertical");
		rb.velocity = new Vector3 (movex * maxSpeed, rb.velocity.y, movey * maxSpeed);


	}
	
	

}
