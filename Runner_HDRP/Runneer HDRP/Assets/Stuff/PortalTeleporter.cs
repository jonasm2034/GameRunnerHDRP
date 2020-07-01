using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
	public Transform reciever;
	public bool hasTeleported = false;

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
			SceneManager.LoadScene(6);
			hasTeleported = true;
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
