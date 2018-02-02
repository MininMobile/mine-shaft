 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    public Transform TerrainTop;
    public Transform TerrainMid;
    public Transform TerrainBot;

    void Start() { Init(); }

    void Init()
    {
        var x = 0;
        var y = 0;

		for (var i = 0; i < 100; i++)
        {

        }

        Instantiate(TerrainTop);
	}
}
