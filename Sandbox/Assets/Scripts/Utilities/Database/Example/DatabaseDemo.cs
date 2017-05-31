using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseDemo : MonoBehaviour 
{
	void Start () 
	{
		UnitData test = Resources.Load<UnitData>("Infantry");
		Debug.Log("The movement speed for Infantry in the database: " + test.movement);
		test = null;
		Resources.UnloadUnusedAssets();
	}
}
