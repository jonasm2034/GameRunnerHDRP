using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
	public Transform reciever;

	private bool playerIsOverlapping = false;

	// Update is called once per frame
	void Update () 
	{
		
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			//playerIsOverlapping = true;
			//player.transform.position = new Vector3(994.43f, 5.8f, 3.93f);
			SceneManager.LoadScene(1);
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player")
		{
			//playerIsOverlapping = false;

		}
	}
}
