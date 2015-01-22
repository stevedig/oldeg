using UnityEngine;
using System.Collections;

public class EggScript : MonoBehaviour 
{
	void Update () 
    {
		//Handles Egg Falling Speed
        float fallSpeed = 2 * Time.deltaTime;
        transform.position -= new Vector3(0, fallSpeed, 0);

        if (transform.position.y < -2 || transform.position.y >= 20)
        {
            Destroy(gameObject); //Destroys EggPrefab
        }
	}
}