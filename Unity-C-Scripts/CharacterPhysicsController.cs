using UnityEngine;
using System.Collections;

public class CharacterPhysicsController : MonoBehaviour {

    private float axis;
    public float speed;
    private Rigidbody2D rbdy;

	// Use this for initialization
	void Awake () {
        rbdy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        axis = Input.GetAxis("Horizontal");
        rbdy.velocity = new Vector2(axis * speed, rbdy.velocity.y);
        if (Input.GetButtonDown("Jump"))
            jump();
	}

    private void jump () {
        rbdy.velocity = new Vector2(rbdy.velocity.x, speed);
    }
}
