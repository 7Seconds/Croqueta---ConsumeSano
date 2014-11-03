using UnityEngine;
using System.Collections;

public class CalorieResume: MonoBehaviour {


	public Texture2D mTextureButton;
	
	public GUISkin mGuiSkin;
	

	int calories = 0;

	string userName;

	int steps;

	float recommendedCalories;

	int selectedFoodCalories;

	int currentConsumedCalories;


	void Start(){

		selectedFoodCalories = PlayerPrefs.GetInt("foodCalories");
		
		recommendedCalories = PlayerPrefs.GetFloat("RecommendedCalories");
		
		currentConsumedCalories =  PlayerPrefs.GetInt("consumedCalories")+selectedFoodCalories;


		}
	
	void OnGUI()
	{
		GUI.skin = mGuiSkin;

		GUI.backgroundColor = new Color(0,0,0,0);

		GUILayout.BeginArea (new Rect (0f,Screen.height*0.25f,Screen.width,Screen.height*0.81f));

		GUILayout.BeginVertical();

			GUILayout.Space (20f);

			GUILayout.BeginHorizontal ();

			GUILayout.FlexibleSpace ();
				GUILayout.Label ("El día de hoy tu mascota ha ");
				GUILayout.Space (20f);
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label ("consumido ");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

				GUILayout.Space (20f);

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label(currentConsumedCalories + " calorias");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.Space (20f);
				
			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label("Recuerda que lo recomendado es:");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.Label(recommendedCalories + " calorias");
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		
		GUILayout.Space (20f);

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				if (GUILayout.Button (mTextureButton)) {

			PlayerPrefs.SetInt("Eat",1);						

			PlayerPrefs.SetInt("consumedCalories",currentConsumedCalories);



			int aux = PlayerPrefs.GetInt("IndexHappines") ;
			if((aux-1)>=0)
				PlayerPrefs.SetInt("IndexHappines",aux-1);
			else
				PlayerPrefs.SetInt("IndexHappines",0);
			
			
			aux = PlayerPrefs.GetInt("IndexEnergy") ;
			if((aux-3)>=0)
				PlayerPrefs.SetInt("IndexEnergy",aux-3);
			else
				PlayerPrefs.SetInt("IndexEnergy",0);						

			aux = PlayerPrefs.GetInt("IndexFood") ;
			if((aux-4)>=0)
				PlayerPrefs.SetInt("IndexFood",aux-4);
			else
				PlayerPrefs.SetInt("IndexFood",0);						

			PlayerPrefs.SetInt("IndexWeight",0);

			Application.LoadLevel ("KitchenScene");
						
				}

				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

		GUILayout.EndVertical();

		GUILayout.EndArea();

		GUI.skin = null;
	}
	
}
