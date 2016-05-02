using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	//LIFE UI
	public Transform lifeBar;
	private Vector3 startSizeLifeBar;
	private Vector3 currentSizeLifeBar;

	//LIFE
	public int dano = 5;
	public int totalLife;
	private int currentLife;

	//EFFECTS
	public GameObject deathParticles;

	
	void Start() {
		currentLife = totalLife;
		startSizeLifeBar = lifeBar.localScale;
		currentSizeLifeBar = lifeBar.localScale;
	}


	public void TirarDano(int dano){
		currentLife -= dano;
		if(currentLife <= 0){
			Wall.Instance.Pontuar(10);
			GameObject.Destroy(this.gameObject);
			Instantiate(deathParticles, this.gameObject.transform.position, Quaternion.identity);
		}

		currentSizeLifeBar.x = currentLife * startSizeLifeBar.x / totalLife;
		if (currentSizeLifeBar.x < 0)
			currentSizeLifeBar.x = 0;
		lifeBar.localScale = currentSizeLifeBar;

	}

	Wall obstacle;

	void Update(){
		if(obstacle== null && IsInvoking("Atacar")){
			CancelInvoke("Atacar");
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.CompareTag("Wall")){
			obstacle = other.collider.GetComponent<Wall>();
			InvokeRepeating("Atacar", 0f, 1f);
		}
	}

	void Atacar(){
		obstacle.TirarDano(this.dano);
	}

}
