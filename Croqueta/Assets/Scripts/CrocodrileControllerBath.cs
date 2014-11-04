using UnityEngine;
using System.Collections;

public class CrocodrileControllerBath : MonoBehaviour {

	public AudioClip roar;
	
	Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		anim.SetTrigger("Cuddle");

		if (Input.touchCount == 1)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
			
				
				if(!audio.isPlaying)
					audio.Play();
			}				
		}
	}
	
	
	
	
}



