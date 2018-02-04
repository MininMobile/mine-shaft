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
        for (var x = 0; x < 100; x++)
        {
            for (var z = 0; z < 100; z++)
            {
                var obj = Instantiate(TerrainTop);
                obj.transform.Translate(x*20, 0, z*20);
            }
        }
	}
}
