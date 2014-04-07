using UnityEngine;
using System.Collections;

public class BeamLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Destroy all things
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Asteroid") {
			Destroy( col.gameObject );
		}
	}
}
