using UnityEngine;
using System.Collections;

public class DestroyParticlesFinished : MonoBehaviour {

	private ParticleSystem thisParticles;
	
	void Start () {
		thisParticles = GetComponent<ParticleSystem> ();
	}

	void Update () {
		if (thisParticles.isPlaying)
			return;

		Destroy (gameObject);
	}
}
