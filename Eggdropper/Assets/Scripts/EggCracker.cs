using UnityEngine;
using System.Collections;

public class EggCracker : MonoBehaviour 
{
	//public AudioClip [] crackClips; //Array For Sounds

	void OnTriggerEnter(Collider col)
	{
		GameObject Egg = col.gameObject;
		Destroy(Egg);

		//audio.PlayOneShot (crackClips[Random.Range(0,crackClips.Length)]); //Egg Crack Array
	}
}