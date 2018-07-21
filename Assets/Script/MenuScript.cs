using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	//public Canvas 
	public Button start;

	void Start () {
		start = GetComponent<Button> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void startButton(){
	
		Application.LoadLevel(1);

	
	
	}
}
