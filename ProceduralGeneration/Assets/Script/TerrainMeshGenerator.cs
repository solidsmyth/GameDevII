using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TerrainMeshGenerator
{
    public static void GenerateTerrainMesh(float[,] heightMap)
    {
        int width = heightMap.GetLength[0];
        int height = heightMap.GetLength[1];

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {

            }
        }
    }
}

public class MeshData
{
    public Vector3[] vertices;
    public int[] triangles;

    public MeshData();
}
