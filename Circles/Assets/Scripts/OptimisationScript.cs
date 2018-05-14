using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Allows for scene changing

public class OptimisationScript : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D (Collider2D colBar) 
	{

		if (colBar.tag == "Barrier") // If the object has the tag of Barrier
		{ 
			GetComponent<Collider2D>().isTrigger = false; // When the player collides with barrier turn off the player colliders trigger
		} 

		if (colBar.tag == "BarrierTwo") // If the object has the tag of BarrierTwo
		{
			GetComponent<Collider2D>().isTrigger = true; // When the player collides with barrier turn off the player colliders trigger
		} 

		if(colBar.tag == "DeleteWall") // If the player collides with an object with DeleteWall
		{ 
			SceneManager.LoadScene ("Circles_MainGame"); // Reset the level
		}

		if (colBar.tag == "SquareDelete") {
			Destroy(gameObject);
		}

	}

	//------------------------------------------------------------------------------------------------------
	
}
