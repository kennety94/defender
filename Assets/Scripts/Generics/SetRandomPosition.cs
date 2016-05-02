using UnityEngine;
using System.Collections;

public class SetRandomPosition : MonoBehaviour {

	public Vector2 min;
	public Vector2 max;
	
	public bool local;
	
	public void Randomize(){
		Vector2 r = Vector2.Lerp(min,max,Random.value);
		if(local)
			this.transform.localPosition = r;
		else
			this.transform.position = r;
	}

}
