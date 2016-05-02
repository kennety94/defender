using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnKey : MonoBehaviour {

	public KeyCode keyCode;

	[System.Serializable]
	public class BoolUnityEvent : UnityEvent<bool> {}

	public BoolUnityEvent OnEvent;
	
	void Update () {
		OnEvent.Invoke(Input.GetKey(keyCode));
	}

}
