using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	[HideInInspector]
    public int theScore = 0;
	public Text scoreUI;
	//public AudioClip levelUp;
	
	void Update () 
    {
        //Movement Code
        float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 3; 
        transform.position += new Vector3(moveInput, 0, 0);

        //Restrict Movement
        if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
	}
	
    void OnGUI()
    {
		scoreUI.text = " Score : " + theScore; //Improved with new Unity 4.6 UI System
    }    
}