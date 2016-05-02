using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

    public int maxEnemyToSpawn;
    private int currentAmountEnemy;


	void Start () {
	
	}
	
	void Update () {
	
	}

    public void IncreaseEnemy()
    {
        currentAmountEnemy++;
    }

    public bool CanSpawn()
    {
        return currentAmountEnemy < maxEnemyToSpawn;
    }

}
