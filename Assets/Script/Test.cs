using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	Rigidbody rb;
	Renderer rend;
	public Material[] material;
	RaycastHit hit;
	int lastColour;
	int currentColour;

	// Use this for initialization
	void Start () {
		lastColour = -1;
		currentColour = -2;
		rb = GetComponent<Rigidbody> ();
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	
	}
	void FixedUpdate () {
		




	}





	void Update () {

		/*if (Input.touchCount > 0) {
			if (Input.GetTouch(0).phase==TouchPhase.Ended && IsGrounded()  == true) {
				rb.AddForce (0f,7000f,0f);

			}
		
		
		}*/

		if ((Input.GetKeyDown ("space") ) && IsGrounded()  == true) {
			rb.AddForce (0f,7000f,0f);

		}





		Vector3 vect = new Vector3 (transform.position.x, transform.position.y+.25f, transform.position.z);
		if (Physics.Raycast (vect, Vector3.right, .3f)) {
		

			Time.timeScale = 0;
		}

		changeColor ();

	
	}





	void OnTriggerEnter(Collider other) {
        


	}
	void OnTriggerExit(Collider other) {
		
		if (other.CompareTag ("ColorBlock")) {


		}

	}
	void changeColor(){
		
		Physics.Raycast (transform.position, Vector3.down, out hit,.25f);

		if (hit.collider != null && hit.collider.CompareTag("ColorBlock")==false) {


			if (hit.collider.CompareTag( "White")) {
				rend.sharedMaterial = material [0];
				currentColour= 0;
				hit.collider.tag = "ColorBlock";
			} else if (hit.collider.CompareTag("Black")) {
				rend.sharedMaterial = material [1]; 
				currentColour = 1;
				hit.collider.tag = "ColorBlock";
			} else if (hit.collider.CompareTag("Blue")) {
				rend.sharedMaterial = material [2];
				currentColour=2;
				hit.collider.tag = "ColorBlock";
			} else if (hit.collider.CompareTag("Yellow")) {
				rend.sharedMaterial = material [3]; 
				currentColour=3;
				hit.collider.tag = "ColorBlock";
			} else if (hit.collider.CompareTag("Violet")) {
				rend.sharedMaterial = material [4]; 
				currentColour=4;
				hit.collider.tag = "ColorBlock";
			} else {
				Debug.Log ("Test.changeColor Coding Error");


			}


			if (currentColour == lastColour && hit.collider.bounds.size.y<1) {
				Debug.Log ("Same Color");
			Time.timeScale = 0;
			} else {
				lastColour = currentColour;
			}
				


	
	
		}
	
	
	}



	void OnCollisionEnter(Collision Col){

	





	}




	bool IsGrounded() {
		Debug.DrawRay(transform.position, -Vector3.up, Color.green);
		return Physics.Raycast(transform.position, -Vector3.up,.5f);
	}
}
