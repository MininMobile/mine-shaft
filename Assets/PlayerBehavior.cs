using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public Rigidbody Body;
    public float Speed = 1f;
    public int JumpHeight = 5;

	void Update()
    {
        // Get Input
        if (Input.GetAxis("Horizontal") != 0)
            this.transform.Translate(Input.GetAxis("Horizontal") * Speed, 0, 0);

        if (Input.GetAxis("Vertical") != 0)
            this.transform.Translate(0, 0, Input.GetAxis("Vertical") * Speed);

        if (Input.GetKeyDown(KeyCode.Space)) { Body.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse); }
    }
}
