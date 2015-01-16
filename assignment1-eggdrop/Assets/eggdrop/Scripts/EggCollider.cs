using UnityEngine;
using System.Collections;

public class EggCollider : MonoBehaviour {

    PlayerScript myPlayerScript;

    //Automatically run when a scene starts
    void Awake()
    {
        myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }

    //Triggered by Unity's Physics
	void OnTriggerEnter(Collider theCollision)
    {
        //In this game we don't need to check *what* we hit; it must be the eggs
        GameObject collisionGO = theCollision.gameObject;
        Destroy(collisionGO);

        myPlayerScript.theScore++;
    }
}
