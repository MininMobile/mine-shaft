using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public float Speed = 1f;

	void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.transform.Translate(Input.GetAxis("Horizontal") * Speed, 0, 0);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            this.transform.Translate(0, 0, Input.GetAxis("Vertical") * Speed);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.transform.Translate(0, Speed, 0);
        }
    }
}
