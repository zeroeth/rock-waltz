using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

	public float rotation_speed = 0.5f;
	public float thrust_speed = 5.0f;
	public float reverse_speed = 0.1f;
	public GameObject projectile;

    public float fire_rate = 0.5f;
    private float next_fire = 0.0f;

	public float bullet_velocity = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	

	// Update is called once per frame
	void FixedUpdate () {
		// Rotate
		float horizontal = -Input.GetAxis ("Horizontal");
		rigidbody2D.AddTorque (horizontal * rotation_speed);


		// Thrust
		if (Input.GetAxis ("Vertical") > 0) {
			rigidbody2D.AddForce (transform.up * thrust_speed);
		}

		if (Input.GetAxis ("Vertical") < 0) {
			rigidbody2D.AddForce (-transform.up * thrust_speed * reverse_speed);
		}


		// Fire
		if (Input.GetButton("Jump") && Time.time > next_fire) {
            next_fire = Time.time + fire_rate;
			GameObject beam = (GameObject) Instantiate(projectile, transform.position, transform.rotation);
			
			// Combine base velocity with parent velocity
			beam.rigidbody2D.velocity = rigidbody2D.velocity + (Vector2)transform.up * bullet_velocity;
		}
	}
}
