using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
    
    public float Speed = 1f;

    private float _jumpingVel = 0f;
    private bool _jumpingUp = false;

	void Update()
    {
        // Get Input
        if (Input.GetAxis("Horizontal") != 0)
            this.transform.Translate(Input.GetAxis("Horizontal") * Speed, 0, 0);

        if (Input.GetAxis("Vertical") != 0)
            this.transform.Translate(0, 0, Input.GetAxis("Vertical") * Speed);

        if (Input.GetKeyUp(KeyCode.Space)) { _jumpingUp = true; }

        // Jumping
        if (_jumpingUp && _jumpingVel > 0)
        {
            if (_jumpingVel < 5)
                _jumpingVel++;
            
            if (_jumpingVel > 5)
                _jumpingVel--;

            _jumpingUp = false;
        }

        this.transform.Translate(0, _jumpingVel, 0);
    }
}
