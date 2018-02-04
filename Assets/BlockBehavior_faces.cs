using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior_faces : MonoBehaviour
{
    MeshRenderer renderer;

    void Start()
    {
        renderer = this.transform.GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collision) { renderer.enabled = false; }
    void OnCollisionExit(Collision collision) { renderer.enabled = true; }
}
