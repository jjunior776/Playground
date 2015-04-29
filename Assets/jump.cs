using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	bool grounded = false;						
	public Transform groundCheck;				
	float groundRadius = 0.2f;					 
	public LayerMask ground;					
	public float jumpForce = 9000f;				

	public Rigidbody rb;							

	void Start () {
		rb = GetComponent<Rigidbody> ();	 	
	}
	
	void Update(){
		if (grounded && (Input.GetKeyDown (KeyCode.Space))) {													
			rb.AddForce(new Vector2(0,jumpForce));
			Debug.Log("skok");
		}
		
	}

	void FixedUpdate(){
		Collider[] hitColliders = Physics.OverlapSphere (groundCheck.position, groundRadius, ground);
		if (hitColliders.Length > 0)
			grounded = true;
		else
			grounded = false;
	
	}
}
