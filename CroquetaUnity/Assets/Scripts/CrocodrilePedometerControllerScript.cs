using UnityEngine;
using System.Collections;

public class CrocodrilePedometerControllerScript : MonoBehaviour {

	private float speed = 1f;

	public int distanceMax;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


		anim.SetFloat("Speed", speed);


		}




	}



