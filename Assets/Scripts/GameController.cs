using UnityEngine;
using System.Collections;

public enum GAME_STATE{
	START,
	INGAME,
	ENDGAME,
	PAUSE
}

public class GameController : MonoBehaviour {

	public GAME_STATE currentState;
	private GAME_STATE nextState;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentState = nextState;

        switch (currentState) {
            case GAME_STATE.START:{
                    break;
            }
            case GAME_STATE.INGAME:{
                    break;
            }
            case GAME_STATE.ENDGAME:{
                    break;
            }
            case GAME_STATE.PAUSE:{
                    break;
            }
        }
	}

	public void ChangeState(GAME_STATE newState){
        nextState = newState;
	}
}
