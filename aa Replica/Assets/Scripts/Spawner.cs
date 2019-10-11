using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;

	/*public void Update ()
	{
		if (Input.GetButtonDown("Fire"))
		{
			SpawnPin();
		}
	}*/

	public void SpawnPin ()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}

}
