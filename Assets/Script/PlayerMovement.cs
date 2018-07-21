using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed=5f;
	// Use this for initialization
	Animator anim;
	Rigidbody rb;
	bool grounded;

	public float force;
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
		grounded = true;
	
	}
	
	// Update is called once per frame





	void Update () {
		
			//Debug.Log (IsGrounded ());
		if (Input.GetKeyDown ("space") && IsGrounded () == true) {
			//Debug.Log (IsGrounded ());
			//anim.SetBool ("Jump", true);
			//anim.Play ("New Animation");
		}
		//else anim.Play ("Idle");

				//rb.velocity=new Vector3 (0f,force,0f);
				//grounded = false;

		}



   void OnTriggerEnter(Collider other) {
		Debug.Log ("Ontriggered ");
		if (other.CompareTag ("ColorBlock")) {
			grounded = true;

		}

		}
	void OnTriggerExit(Collider other) {
		Debug.Log ("Ontriggered ");
		if (other.CompareTag ("ColorBlock")) {
			grounded = false;

		}

	}


	/*void OnCollisionEnter(Collision Col){
		//Debug.Log ("OnCollision ");
		if (Col.gameObject.CompareTag ("ColorBlock")) {
			grounded = true;

		}
	}
	void OnCollisionExit(Collision Col){
		//Debug.Log ("OnCollision ");
		if (Col.gameObject.CompareTag ("ColorBlock")) {
			//grounded = false;

			}
	
	}*/
	bool IsGrounded() {
		Debug.DrawRay(transform.position, -Vector3.up, Color.green);
		return Physics.Raycast(transform.position, -Vector3.up,.6f/*distToGround */);
	}


}

