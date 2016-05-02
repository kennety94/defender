using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class ConstantVelocity2D : MonoBehaviour {

	public Vector2 velocity;
	public Vector2 multiplier = Vector2.one;

	public float VelocityX { set{ velocity.x = value; } }
	public float VelocityY { set{ velocity.y = value; } }
	public float MultiplierX { set{ multiplier.x = value; } }
	public float MultiplierY { set{ multiplier.y = value; } }

	public Space relativeTo;

	public bool ignoreX;
	public bool ignoreY;

	void Start () {

	}

	void FixedUpdate () {
		Rigidbody2D rb = GetComponent<Rigidbody2D>();

		Vector2 wantedVel = new Vector2(velocity.x * multiplier.x,
		                                velocity.y * multiplier.y);

		if(relativeTo == Space.Self){
			wantedVel = transform.TransformDirection(wantedVel);
		}

		if(rb.isKinematic){
			Vector2 newPos = rb.position + wantedVel * Time.fixedDeltaTime;
			rb.MovePosition(newPos);
		}else{
			Vector2 currentVel = rb.velocity;
			if(!ignoreX)
				currentVel.x = wantedVel.x;
			if(!ignoreY)
				currentVel.y = wantedVel.y;
			rb.velocity = currentVel;
		}
	}
}
