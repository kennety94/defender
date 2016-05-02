using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button quitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		quitText = quitText.GetComponent<Button>();

		quitMenu.enabled = false;
	}

	public void Default(){
		quitMenu.enabled = false;
		startText.enabled = true;
		quitText.enabled = true;
	}

	public void PlayPress(){
		Application.LoadLevel ("HowToPlay");
	}

	public void StartGame(){
		Application.LoadLevel ("Base");
	}


	public void QuitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		quitText.enabled = false;
	}
	
	public void QuitGame(){
		Application.Quit ();
	}

}
