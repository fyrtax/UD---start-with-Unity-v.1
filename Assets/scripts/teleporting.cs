using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour
{
	public GameObject destination;
    public string whatTeleport = "Player";

	void OnTriggerEnter(Collider collider)
	{
        if (collider.CompareTag(whatTeleport) || collider.gameObject.layer == 1)
		{
			Vector3 targetPosition = destination.transform.position;
			targetPosition += destination.transform.forward * 2; //new Vector3 (1, 1, 5);
			collider.transform.position = targetPosition;
                
            if (destination.GetComponent<AudioSource>())
			destination.GetComponent<AudioSource>().Play();
		}
	}
}