using UnityEngine;
using System.Collections;

public class ConstantRotate : MonoBehaviour {

	public float rotation_speed = 35.0f;

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.AngleAxis(Random.value * 360.0f, Vector3.forward);
		rotation_speed = (Random.value - 0.5f) * rotation_speed * 2.0f;

		//rigidbody2D.AddTorque(rotation_speed);
		rigidbody2D.angularVelocity = rotation_speed;
		rigidbody2D.AddForce (transform.up * (Random.Range(5.0f, 100.0f)));
	}


	// Update is called once per frame
	void FixedUpdate () {
		//rigidbody2D.angularVelocity = rotation_speed;
	}


	// Collide
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			//Destroy( col.gameObject );
		}
		else if (col.gameObject.tag == "Asteroid") {
			// Split if velocity high enough
		}
	}
}
