using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    private LevelController levelController;


	void Start () {
        levelController = FindObjectOfType(typeof(LevelController)) as LevelController;
	}
	
	
	void Update () {
        if (levelController.CanSpawn()) {
            levelController.IncreaseEnemy();
        }
	}
}
