using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	public int rotationOffset = 90;
	
	void Update () {
		//Subtraindo a posiçao do player pela do mouse
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		difference.Normalize ();

		float rotationz = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0f, 0f, rotationz + rotationOffset);

	}
}
