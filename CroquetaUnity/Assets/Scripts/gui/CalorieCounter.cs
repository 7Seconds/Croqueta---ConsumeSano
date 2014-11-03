using UnityEngine;
using System.Collections;

public class CalorieCounter: MonoBehaviour {


	public Texture2D mTextureButton;
	
	public GUISkin mGuiSkin;
	

	int calories = 0;

	string userName;

	int steps;


	void Start(){

		userName = PlayerPrefs.GetString ("UserName");

		steps = PlayerPrefs.GetInt ("StepNumber");

		calories = (int)(steps * 0.5);

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
				GUILayout.Label ("¡Felicidades " + userName + "!");
				GUILayout.Space (20f);
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label ("al caminar quemaste ");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

				GUILayout.Space (20f);

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label(calories + " calorias");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.Space (20f);
				
			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label("Recuerda hacer al menos");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label("treinta minutos de ejercicio al día");
				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		
		GUILayout.Space (20f);

			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				if (GUILayout.Button (mTextureButton)) {
			int aux = PlayerPrefs.GetInt("IndexHappines") ;
			if((aux-4)>=0)
				PlayerPrefs.SetInt("IndexHappines",aux-4);
			else
				PlayerPrefs.SetInt("IndexHappines",0);
			
			
			aux = PlayerPrefs.GetInt("IndexEnergy") ;
			if((aux-3)>=0)
				PlayerPrefs.SetInt("IndexEnergy",aux-3);
			else
				PlayerPrefs.SetInt("IndexEnergy",0);						

						Application.LoadLevel ("ParkScene");
						
				}

				GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

		GUILayout.EndVertical();

		GUILayout.EndArea();

		GUI.skin = null;
	}
	
}
