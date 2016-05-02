using UnityEngine;
using System.Collections;

public class Creator : MonoBehaviour {

	public GameObject prefab;

	public bool useRotation;

	public Transform parent;

	public void Create(){
		GameObject copy = (GameObject)Instantiate(
			prefab, 
			this.transform.position, 
			useRotation ? this.transform.rotation : Quaternion.identity);

		if(parent != null){
			copy.transform.SetParent(parent);
		}
	}

}
