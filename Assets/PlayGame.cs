using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public Button playText;

	void Start () {
		playText = playText.GetComponent<Button>();
	}

	public void Default(){
		playText.enabled = true;
	}

	public void StartGame(){
		Application.LoadLevel ("Base");
	}
}
