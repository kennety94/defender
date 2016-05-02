using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Timer : MonoBehaviour {

	public float startTime;
	public float repeatTime = 1f;

	public UnityEvent OnEvent;

	void OnEnable () {
		Invoke("Call", startTime);
	}
	void OnDisable() {
		CancelInvoke();
	}

	public void Call(){
		OnEvent.Invoke();
		Invoke("Call", repeatTime);
	}

}
