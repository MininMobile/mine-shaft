 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{

    public Transform TerrainTop;
    public Transform TerrainMid;
    public Transform TerrainBot;

    void Start() { Init(); }

    void Init()
    {
        for (var x = 0; x < 4; x++)
        {
            for (var z = 0; z < 4; z++)
            {
                var chk = Instantiate(GenerateChunk());
                chk.Translate(x * 360, 0, z * 360);
            }
        }
    }

    Transform GenerateChunk()
    {
        Transform chunk = new GameObject().transform;

        for (var x = 0; x < 16; x++)
        {
            for (var z = 0; z < 16; z++)
            {
                var obj = Instantiate(TerrainTop);
                obj.Translate(x * 20, 0, z * 20);
                obj.parent = chunk;
            }
        }

        return chunk;
    }
}
