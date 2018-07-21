using UnityEngine;
using System.Collections;

public class TilesGenarator : MonoBehaviour {

	// Use this for initialization
	public GameObject[] Tiles;
	public GameObject[] Obstracle;
	public float Wide;
	public GameObject CurrentTiles;
	bool ObstracleCounter;
	int last;
	int current;
	int temp;
	float timer;
	Vector3 tempPos;
	int Score;


	void Start () {
		
		Score = 0;
		last = 0;
		current = 5;
		ObstracleCounter = true;
		timer = 0;
		for (int i = 1; i <= 15; i++) {
			TilesSpawner ();
		}

	
	}
	
	// Update is called once per frame
	void Update () {

		//Spowner ();
		timer+=Time.deltaTime;
		//Debug.Log (timer);

	
	}
	void OnTriggerEnter(Collider other) {
		 
			Destroy (other.gameObject);
			Score++;
			Spowner();
		    Debug.Log (Score);
	}

	void Spowner(){

		if (ObstracleCounter == true && timer>1f) {
			TilesSpawner ();
			temp = Random .Range(0, 2);
			if (temp == 0 ) {
			TilesSpawner ();
				} else {
				TilesSpawner ();
			}





			ObstracleSpawner ();

		
		} else {
			TilesSpawner ();
		
		}

	}




	void TilesSpawner(){
		temp = Random.Range (0,5);

		tempPos = new Vector3 (CurrentTiles.transform.position.x+Wide, 0f, 0f);
		if (temp == current && current == last) {
			TilesSpawner ();
			last = current;
			current = temp;
		} else {
			
			CurrentTiles = (GameObject) Instantiate (Tiles[temp],tempPos,Quaternion.identity);

		}

	}





	void  ObstracleSpawner(){
		temp = Random.Range (0, 3);
		tempPos = new Vector3 (CurrentTiles.transform.position.x+Wide, .3f, 0f);
		//Debug.Log ("Instantiate Obatracle");
 		CurrentTiles = (GameObject) Instantiate (Obstracle[temp],tempPos,Quaternion.identity);
		ObstracleCounter = true;
		timer = 0f;
		//Instantiate(hoard, Vector2 (x, y, 0), Quaternion.identity);
	}


}
