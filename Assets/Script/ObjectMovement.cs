using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {

	// Use this for initialization
	float speed=4f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-speed*Time.deltaTime,0f,0f);
	
	}
}
