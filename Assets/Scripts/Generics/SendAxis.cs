using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class SendAxis : MonoBehaviour {

	public string axisName;

	public float multiplier = 1f;
	public float min = -1f;
	public float max = 1f;

	[System.Serializable]
	public class FloatUnityEvent : UnityEvent<float>{}

	public FloatUnityEvent OnEvent;

	void Update () {
		float axis = Input.GetAxis(axisName);
		OnEvent.Invoke(Mathf.Clamp(axis * multiplier, min, max));
	}
}
