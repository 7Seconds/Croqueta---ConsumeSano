﻿using System.Collections;
using UnityEngine;

public class SceneRoomSleep: MonoBehaviour {
	
	public Texture2D arrowRight;
	
	public Texture2D arrowLeft;
	public Texture2D[] medHappiness;
	public Texture2D[] medEnergy;
	public Texture2D[] medFood;
	public Texture2D[] medWeight;
	private float topSpace = 5f;
	private float buttonSpace = 5f;
	public Texture sleepTexture;
	public Texture closetTexture;


	private int lapse = 8;

	static int indexFood;
	
	static int indexHappines;
	
	static int indexEnergy;
	
	static int indexWeight;

	private float countDown = 0f;



	void Start(){

		indexFood = PlayerPrefs.GetInt("IndexFood");
		
		indexHappines = PlayerPrefs.GetInt("IndexHappines");
		
		indexEnergy = PlayerPrefs.GetInt("IndexEnergy");
		
		indexWeight = PlayerPrefs.GetInt("IndexWeight");
		
	}
	
	void OnGUI()
	{

		updateIndex ();



		GUI.backgroundColor = new Color (0, 0, 0, 0);
		
		if (GUI.Button (new Rect (0, Screen.height / 2 - (arrowRight.height / 2), arrowLeft.width, arrowLeft.height), arrowLeft)) {
			Application.LoadLevel("BathroomScene");
				}
		
		if (GUI.Button (new Rect (Screen.width - arrowRight.width, Screen.height / 2 - (arrowRight.height / 2), arrowLeft.width, arrowLeft.height), arrowRight)) {
			Application.LoadLevel("KitchenScene");
				}
		
		GUILayout.BeginArea (new Rect (0f, topSpace, Screen.width, topSpace + medEnergy [0].height));						

		GUILayout.BeginHorizontal ();

		GUILayout.FlexibleSpace ();

		GUILayout.Box(medFood[indexFood]);
		
		GUILayout.Box(medEnergy[indexEnergy]);

		
		GUILayout.Box(medHappiness[indexHappines]);
		
		GUILayout.Box(medWeight[indexWeight]);


		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal ();

		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (0f, Screen.height - closetTexture.height- buttonSpace, Screen.width, buttonSpace + closetTexture.height));						

		GUILayout.BeginHorizontal ();

		GUILayout.FlexibleSpace ();

		GUILayout.Button(closetTexture);

		GUILayout.Space (80f);

		if(GUILayout.Button(sleepTexture))
			Application.LoadLevel("RoomScene");

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal ();

		GUILayout.EndArea();

	}    


	private void updateIndex(){
		
		countDown += Time.deltaTime;
		
		if(((int)countDown == lapse)){
			countDown = 0f;
			
			if(indexFood < 7){
				indexFood++;
				
				PlayerPrefs.SetInt("IndexFood",indexFood);
			}
			
			if(indexFood > 5){
				if(indexWeight<7)
				{
					indexWeight++;
					PlayerPrefs.SetInt("IndexWeight",indexWeight);
				}
											
				
			}
			
			if(indexHappines > 0){
				indexHappines--;							
				PlayerPrefs.SetInt("IndexHappines",indexHappines);
			}
			
			if(indexEnergy > 0){
				indexEnergy--;
				
				PlayerPrefs.SetInt("IndexEnergy",indexEnergy);
				
			}
		}
	}

}