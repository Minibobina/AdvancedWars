using System;
using UnityEngine;

public class UnitData : ScriptableObject 
{
	public int movement;
 
    public void Load (string line)
    {
        string[] elements = line.Split(',');
        name = elements[0];
        movement = Convert.ToInt32( elements[1] );
    }
}
