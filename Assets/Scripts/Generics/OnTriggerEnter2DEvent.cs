using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnTriggerEnter2DEvent : MonoBehaviour {

	[System.Serializable]
	public class Collider2DUnityEvent : UnityEvent<Collider2D>{}

	public string[] tags;

	public Collider2DUnityEvent OnEvent;

	void OnTriggerEnter2D(Collider2D col){
		if(tags.Length == 0){
			OnEvent.Invoke(col);
		}else{
			foreach(string tag in tags){
				if(col.CompareTag(tag)){
					OnEvent.Invoke(col);
					break;
				}
			}
		}
	}

}
