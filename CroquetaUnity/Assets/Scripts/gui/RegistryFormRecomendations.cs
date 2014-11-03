using UnityEngine;
using System.Collections;

public class RegistryFormRecomendations: MonoBehaviour {

	public Texture2D mTextureSwing;

	public Texture2D mTextureBalloon;

	public Texture2D mTextureButton;
	
	private float spaceBetweenLines = 15f;


	public GUISkin mGuiSkin;

	public GUISkin mGuiSkinHighLight;

	private float spaceBetweenGUIElements = 5f;

	private float calories;

	void Start(){

		calories = PlayerPrefs.GetFloat ("RecommendedCalories");

		Debug.Log ("test" + calories);

		}
	
	void OnGUI()
	{
	
		GUI.backgroundColor = new Color(0,0,0,0);

		GUI.skin = mGuiSkin;

		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0f,Screen.height*0.23f,Screen.width,Screen.height*0.81f));

		GUILayout.BeginVertical();


		GUILayout.BeginHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.Label("Desayuno",GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIElements);

		GUI.skin = mGuiSkinHighLight;

		GUILayout.Label(""+(int)(calories*0.2f),GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkin;

		GUILayout.Label("calorias",GUILayout.ExpandWidth(false));

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.Label("Comida",GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkinHighLight;

		GUILayout.Space (spaceBetweenGUIElements);
		
		GUILayout.Label(""+(int)(calories*0.3f),GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkin;
		
		GUILayout.Label("calorias",GUILayout.ExpandWidth(false));
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace ();

		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.Label("Cena",GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIElements);

		GUI.skin = mGuiSkinHighLight;
		
		GUILayout.Label(""+(int)(calories*0.2f),GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkin;
		
		GUILayout.Label("calorias",GUILayout.ExpandWidth(false));
		
		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace ();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.Label("Dos Refrigerios",GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIElements);

		GUI.skin = mGuiSkinHighLight;
		
		GUILayout.Label("" +(int)(calories*0.15f),GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkin;
		
		GUILayout.Label("calorias cada uno",GUILayout.ExpandWidth(false));
		
		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace ();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.Label("Total al día",GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIElements);

		GUI.skin = mGuiSkinHighLight;


		
		GUILayout.Label(""+(int)calories,GUILayout.ExpandWidth(false));

		GUI.skin = mGuiSkin;
		
		GUILayout.Label("calorias",GUILayout.ExpandWidth(false));

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();

		GUILayout.Space((Screen.width/2) - (mTextureButton.width/2));


		if (GUILayout.Button (mTextureButton)) {





			Application.LoadLevel("SelectPet");


		}
		
		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();


		GUILayout.EndVertical();

		GUILayout.EndArea();

		GUI.skin = null;


	}
	
}
