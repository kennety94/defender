using UnityEngine;
using System.Collections;

public class OverController : MonoBehaviour {

	public float delayTime = 2f;

	// Use this for initialization
	void Start () {
		Invoke ("BackToMenu", delayTime);
	}
	
	void BackToMenu(){
		Application.LoadLevel ("MainMenu");
	}
}
