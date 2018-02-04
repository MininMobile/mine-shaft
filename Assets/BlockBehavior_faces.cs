using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior_faces : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = this.transform.GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collision) { meshRenderer.enabled = false; }
    void OnCollisionExit(Collision collision) { meshRenderer.enabled = true; }
}
