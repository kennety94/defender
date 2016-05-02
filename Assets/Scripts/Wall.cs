using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Wall : MonoBehaviour {

	private static Wall _instance;
	public static Wall Instance{
		get{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<Wall>();
			return _instance;
		}
	}

	//UI
	public Transform lifeBar;
	private Vector3 startSizeLifeBar;
	private Vector3 currentSizeLifeBar;
	public Text points;

	//LIFE
	public int totalLife;
	private int currentLife;

	//POINTS
	private int currentPoints;


	void Start () {
		currentLife = totalLife;
		startSizeLifeBar = lifeBar.localScale;
		currentSizeLifeBar = lifeBar.localScale;
	}

//	void Update(){
//		Debug.Log (currentPoints);
//	}

	public void TirarDano(int dano){
		currentLife -= dano;
		if(currentLife < 0){
			currentLife = 0;
			Morrer();
		}

		currentSizeLifeBar.x = currentLife * startSizeLifeBar.x / totalLife;
		if (currentSizeLifeBar.x < 0)
			currentSizeLifeBar.x = 0;
		lifeBar.localScale = currentSizeLifeBar;

	}

	void Morrer(){
		if(this && this.gameObject)
			Application.LoadLevel ("GameOver");
	}

	public void Pontuar(int pontos){
		currentPoints += pontos;
		points.text = currentPoints.ToString();
	}

}
