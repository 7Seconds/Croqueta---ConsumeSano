using UnityEngine;
using System.Collections;

public class CrocodrileControllerSript : MonoBehaviour {

	private float speed = 2f;

	private int distanceMax = 350;

	private int distance = 0;

	public AudioClip roar;

	public static Animator anim;

	public int currentScene;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

			
		if( PlayerPrefs.GetInt("consumedCalories")>(int)PlayerPrefs.GetFloat("RecommendedCalories"))
			anim.SetBool("Fat",true);		


		int indexHappines = PlayerPrefs.GetInt("IndexHappines");
		
		if(indexHappines > 4)
			CrocodrileControllerSript.animSad(true);
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat("Speed", speed);

		distance ++;

		rigidbody2D.velocity = new Vector2 (speed*-1f, rigidbody2D.velocity.y);

		if (distanceMax <= distance) {
			speed = 0;

			if(PlayerPrefs.GetInt("Eat") == 1){
				anim.SetTrigger("Eat");
				PlayerPrefs.SetInt("Eat",0);	
			}

		}
	
		if (Input.touchCount == 1)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				if(currentScene ==0)
					SceneRoom.addIndex(2,1);

				if(currentScene ==1)
					SceneBathroom.addIndex(2,1);

				if(currentScene ==2)
					ScenePark.addIndex(2,1);

				if(currentScene ==3)
					SceneKitchen.addIndex(2,1);

				anim.SetTrigger("Cuddle");

				if(!audio.isPlaying)
					audio.Play();
				}				
			}
		}

	public static void animEating(){
		anim.SetTrigger("Eat");
	}

	public static void animSad(bool state){
		anim.SetBool("Sad",state);		
	}

	public static void animFat(bool state){
		anim.SetBool("Fat",state);		
	}


	}



