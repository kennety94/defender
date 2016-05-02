using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnKeyDown : MonoBehaviour {

	public KeyCode keyCode;

	public UnityEvent OnEvent;

	void Update () {
		if(Input.GetKeyDown(keyCode)){
			OnEvent.Invoke();
		}
	}
}
