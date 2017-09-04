using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingParticleController : MonoBehaviour {


	public Slider zrotation;
	public Slider spread;
	public Slider emissionRateSlider;

	private float deltaRotation;
	private float deltaSpread;
	private float emissionRate;
	private ParticleSystem particles;

	private Vector3 defaultPosition = new Vector3(6.41f,-0.37f,-6.42f); //defailt = 8,3,-8 //FLAG X VALUE CHANGED TO 18 FROM 8

	// Use this for initialization
	void Start () {
		particles = FindObjectOfType<ParticleSystem> ();
		var particleShape = particles.shape;
		particleShape.enabled = true;
		particleShape.angle = 10;
	}

	// Update is called once per frame
	void Update () {

		//get slider positions
		deltaRotation = zrotation.value;
		deltaSpread = spread.value;
		emissionRate = emissionRateSlider.value;

		//assign slider values to particle system
		transform.position = defaultPosition ;
		transform.eulerAngles = new Vector3 (0f, 45f-deltaRotation , 0f );

		//get particle shape component and modify with slider value
		var particleShape = particles.shape;
		particleShape.enabled = true;
		particleShape.angle = deltaSpread;

		//get particle emission component and modify with slider value
		var particleEmission = particles.emission;
		particleEmission.enabled = true;
		particleEmission.rateOverTime = emissionRate;

	}
}
