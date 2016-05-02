using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnKeyUp : MonoBehaviour {

	public KeyCode keyCode;

	public UnityEvent OnEvent;

	void Update () {
		if(Input.GetKeyUp(keyCode)){
			OnEvent.Invoke();
		}
	}
}
