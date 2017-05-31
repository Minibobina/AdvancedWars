using System;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour 
{
	void OnEnable ()
    {
        this.AddObserver(OnNotification, Notifications.TEST_NOTIFICATION);
    }
 
    void OnDisable ()
    {
        this.RemoveObserver(OnNotification, Notifications.TEST_NOTIFICATION);
    }
 
    void OnNotification (object sender, EventArgs e)
    {
        Debug.Log("Observer got notification! " + ((MessageEventArgs)e).message);
    }
}
