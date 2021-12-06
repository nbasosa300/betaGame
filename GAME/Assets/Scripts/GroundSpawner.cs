using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject GroundTile;
    Vector3 NextSpawn;
    // Start is called before the first frame update
   public  void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = Instantiate(GroundTile, NextSpawn, Quaternion.identity);
        NextSpawn = temp.transform.GetChild(1).transform.position;
    }


   public  void SpawnTile()
    { 
        
    }
}
