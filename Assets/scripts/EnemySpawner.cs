using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int columns = 6;
    public int rows = 3;
    public Vector3 startPos;
    public Vector3 spacing = new Vector3(1.5f, 0f, 1.2f);


    void Start()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Vector3 pos = startPos + new Vector3(c * spacing.x, 0f, r * spacing.z);
                Instantiate(enemyPrefab, pos, Quaternion.identity);
            }
        }
    }
}