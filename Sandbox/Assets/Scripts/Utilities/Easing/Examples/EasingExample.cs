using System;
using UnityEngine;

public class EasingExample : MonoBehaviour 
{
	/* 
	EasingControl ec;

	void Start () 
	{
		ec = gameObject.AddComponent<EasingControl>();
		ec.startValue = -5;
		ec.endValue = 5;
		ec.duration = 3;
		ec.loopCount = -1; // Inifinite
		//ec.loopCount = 0; // OnCompletedEvent will be fired
		ec.loopType = EasingControl.LoopType.PingPong;
		ec.equation = EasingEquations.EaseInOutQuad;
		ec.updateEvent += OnUpdateEvent;
		ec.completedEvent += OnCompletedEvent;
		ec.Play();
	}

	void OnUpdateEvent(object sender, EventArgs e)
	{
		transform.localPosition = new Vector3(ec.currentValue, 0 , 0);
	}

	void OnCompletedEvent(object sender, EventArgs e)
	{
		Debug.Log("OnCompletedEvent: " + sender);
	}
	*/

	void Start ()
	{
		/*
		// Runs default
		//transform.MoveTo(new Vector3(5,0,0), 3f, EasingEquations.EaseInOutQuad);
		*/

		Tweener tweener = transform.MoveTo( new Vector3(5, 0, 0), 3f, EasingEquations.EaseInOutQuad );
        tweener.easingControl.completedEvent += OnCompletedEvent;
		
		/*
		// Example like above
		Tweener tweener = transform.MoveTo( new Vector3(5, 0, 0), 3f, EasingEquations.EaseInOutQuad );
		tweener.easingControl.loopCount = -1;
        tweener.easingControl.loopType = EasingControl.LoopType.PingPong;
		*/
	}

	void OnCompletedEvent(object sender, EventArgs e)
	{
		Debug.Log("OnCompletedEvent: " + sender);
	}
}
