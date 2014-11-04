using System.Collections;
using UnityEngine;

public class SceneRefrigerator: MonoBehaviour {

	public Texture2D[] foodTexture;
	

	public Texture buttonAccept;

	public Texture buttonAddFood;
	
	public Texture buttonFinish;

	public GUISkin mGuiSkin;

	private float correctionTextures = 30f;

	string foodName;

	string foodGroup;

	string calories;

	string portion;

	int indexIcon = 0;

	bool isSelected = false;
	void OnGUI()
	{

		GUI.skin = mGuiSkin;

		GUI.backgroundColor = new Color (0, 0, 0, 0);


		GUILayout.BeginArea (new Rect (0f, (Screen.height*0.2f)-foodTexture [0].height-16f, Screen.width/2f, foodTexture[0].height+5f));						

		
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [0])) {
			foodName = "Leche de fresa";
			foodGroup = "Productos lacteos";
			calories = "160";
			portion = "200";
			indexIcon = 0;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [1])) {
			foodName = "Fresas";
			foodGroup = "Verduras y frutas";
			calories = "32";
			portion = "100";
			indexIcon = 1;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [2])) {
			foodName = "Platano";
			foodGroup = "Verduras y frutas";
			calories = "105";
			portion = "118";
			indexIcon = 2;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [3])) {
			foodName = "Pierna de pollo";
			foodGroup = "Origen animal";
			calories = "212";
			portion = "112";
			indexIcon = 3;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (0f, (Screen.height*0.4f)-foodTexture [0].height-3f, Screen.width/2f, foodTexture[0].height+5f));						
		
		
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [4])) {
			foodName = "Pescado";
			foodGroup = "Origen animal";
			calories = "93";
			portion = "85";
			indexIcon = 4;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [6])) {
			foodName = "Carne";
			foodGroup = "167";
			foodGroup = "Origen animal";
			portion = "100";
			indexIcon = 6;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [5])) {
			foodName = "Huevo";
			foodGroup = "Origen animal";
			calories = "52";
			portion = "100";
			indexIcon = 5;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [7])) {
			foodName = "Arroz";
			foodGroup = "Cereales";
			calories = "130";
			portion = "100";
			indexIcon = 7;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (0f, (Screen.height*0.6f)-foodTexture [0].height+7f, Screen.width/2f, foodTexture[0].height+5f));						
		
		
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [8])) {
			foodName = "Pasta";
			foodGroup = "Cereales";
			calories = "345";
			portion = "200";
			indexIcon = 8;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [9])) {
			foodName = "Bolillo";
			foodGroup = "Panadería";
			calories = "125";
			portion = "45";
			isSelected = true;
			indexIcon = 9;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [10])) {
			foodName = "Pan integral";
			foodGroup = "Panadería";
			calories = "293";
			portion = "100";
			isSelected = true;
			indexIcon = 10;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [11])) {
			foodName = "Refresco muy azucarado";
			foodGroup = "Bebidas";
			calories = "3000";
			portion = "355";
			indexIcon = 11;
			isSelected = true;
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (0f, (Screen.height*0.8f)-foodTexture [0].height+18f, Screen.width/2f, foodTexture[0].height+5f));						
		
		
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [12])) {
			foodName = "Queso Oaxaca";
			foodGroup = "Productos lácteos";
			calories = "356";
			isSelected = true;
			portion = "100";
			indexIcon = 12;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [13])) {
			foodName = "Leche";
			foodGroup = "Productos lácteos";
			calories = "42";
			portion = "100";
			isSelected = true;
			indexIcon = 13;
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (foodTexture [14])) {
			foodName = "Champiñones";
			foodGroup = "Verduras y frutas";
			calories = "22";
			isSelected = true;
			portion = "100";
			indexIcon = 14;
		}
		if(PlayerPrefs.HasKey("nameFood")){
			GUILayout.FlexibleSpace ();
			if (GUILayout.Button (foodTexture [PlayerPrefs.GetInt("icon")])) {
				foodName = PlayerPrefs.GetString("nameFood");
				foodGroup = PlayerPrefs.GetString("foodGroup");
				calories = PlayerPrefs.GetString("calories");
				portion = PlayerPrefs.GetString("portion");
				isSelected = true;
				indexIcon = PlayerPrefs.GetInt("icon");

			}
		
		}

		GUILayout.FlexibleSpace ();


		GUILayout.EndHorizontal ();
		GUILayout.EndArea();



		GUILayout.BeginArea (new Rect (0f, ((Screen.height)-foodTexture [0].height)-100f, Screen.width/2f, buttonAddFood.height+5f));						
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (buttonAddFood))
				Application.LoadLevel ("AddFoodScene");
				
		GUILayout.FlexibleSpace ();


		if(GUILayout.Button (buttonFinish))
			Application.LoadLevel ("SceneKitchen");

		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();

		GUILayout.EndArea();


				

		//Información de Alimentos

		GUILayout.BeginArea (new Rect (Screen.width/2, 0f, Screen.width/2, Screen.height));						
		
		GUILayout.BeginVertical ();

		if (isSelected) {
				
						GUILayout.FlexibleSpace ();


						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Label (foodName);
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();

						GUILayout.FlexibleSpace ();

						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Button (foodTexture [indexIcon]);
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();


						GUILayout.FlexibleSpace ();
						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Label ("Grupo alimenticio");
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();

						GUILayout.FlexibleSpace ();
						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Label (foodGroup);
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();

						GUILayout.FlexibleSpace ();

						GUILayout.FlexibleSpace ();
						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Label ("Porción: " + portion + " ml/gr");
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();
		
						GUILayout.FlexibleSpace ();

						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();
						GUILayout.Label (calories + " calorias");
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();


						GUILayout.FlexibleSpace ();



						GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace ();


						if (GUILayout.Button (buttonAccept)) {

							PlayerPrefs.SetInt("foodCalories",int.Parse(calories));


							Application.LoadLevel ("CalorieResume");

						}
						GUILayout.FlexibleSpace ();
						GUILayout.EndHorizontal ();

						GUILayout.FlexibleSpace ();
				}

		GUILayout.EndVertical ();

		GUILayout.EndArea();






		GUI.skin = null;

	}    
}