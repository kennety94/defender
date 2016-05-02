using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {

	public GameObject enemy;
	public GameObject player;
	public float distance;


	private bool isLeft;


	void Start () {
		isLeft = true;
		InvokeRepeating ("CheckDirectionPlayer", 0f, 1.5f);
	}


	void ChangeDirectionEnemy(){
		if (isLeft) {
			enemy.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			enemy.GetComponent<ConstantVelocity2D> ().velocity.x = -2f;
		} else {
			enemy.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			enemy.GetComponent<ConstantVelocity2D> ().velocity.x = 2f;
		}
	}

	void CheckDirectionPlayer(){
		//se o player tiver no x negativo do inimigo
		//siga para esquerda
		if(player.transform.position.x > enemy.transform.position.x){
			isLeft = false;
			ChangeDirectionEnemy();
		}
		//se estiver positivo
		//siga para direita
		if(player.transform.position.x < enemy.transform.position.x){
			isLeft = true;
			ChangeDirectionEnemy();
		}
		//ativar o constant vel
		enemy.GetComponent<ConstantVelocity2D>().enabled = true;
	}


	//Verifica o que entrou no campo de visao
	void OnTriggerEnter2D(Collider2D col){

		//Se for o player faz...
		if (col.CompareTag ("Player")) {
			CheckDirectionPlayer();
		}
	}

}
