using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour 
{
	void Start () 
	{
		this.PostNotification(Notifications.TEST_NOTIFICATION, new MessageEventArgs("This is a test of the Notification Center"));
	}
}
