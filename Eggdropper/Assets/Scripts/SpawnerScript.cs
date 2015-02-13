using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour 
{
    public Transform Egg;
    private float nextEggTime = 0.0f;
    public float spawnRate = 1.5f;
 	
	void Update () 
    {
        if (nextEggTime < Time.time)
        {
            SpawnEgg();
            nextEggTime = Time.time + spawnRate;

            //Increase Spawn Rate Over Time, Clamp At 0.3f
            spawnRate *= 0.98f;
            spawnRate = Mathf.Clamp(spawnRate, 0.3f, 99f);
        }
	}

    void SpawnEgg()
    {
        float addXPos = Random.Range(-1.6f, 1.6f);
        Vector3 spawnPos = transform.position + new Vector3(addXPos,0,0);
        Instantiate(Egg, spawnPos, Quaternion.identity);
    }
}