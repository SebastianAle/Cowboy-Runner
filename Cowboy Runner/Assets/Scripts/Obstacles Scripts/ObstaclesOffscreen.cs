﻿using UnityEngine;
using System.Collections;

public class ObstaclesOffscreen : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Collector") 
		{
			gameObject.SetActive (false);
		}
	}
}
