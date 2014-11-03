using UnityEngine;
using System.Collections;

public class RegistryFormWeight: MonoBehaviour {

	public Texture2D mTextureSwing;

	public Texture2D mTextureBalloon;

	public Texture2D mTextureButton;

	private float spaceBetweenGUIELements = 5f;
	
	private string weightUser = "xxxx";

	private string heightUser = "xxxx";

	public GUISkin mGuiSkin;

	private bool isMuch = false;

	private bool isRegular = false;

	private bool isLow = false;

	public Texture2D mToggleMuchOn;

	public Texture2D mToggleMuchOff;

	private Texture2D mToggleMuch;

	public Texture2D mToggleRegularOn;

	public Texture2D mToggleRegularOff;

	private Texture2D mToggleRegular;

	public Texture2D mToggleLowOn;

	public Texture2D mToggleLowOff;

	private Texture2D mToggleLow;
	
	void OnGUI()
	{

		GUI.skin = mGuiSkin;

		GUI.backgroundColor = new Color(0,0,0,0);

		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0f,Screen.height*0.25f,Screen.width,Screen.height*0.81f));

		GUILayout.BeginVertical();

		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		GUILayout.Space (spaceBetweenGUIELements);

		GUILayout.Box(mTextureSwing,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		GUILayout.Space (spaceBetweenGUIELements);

		GUILayout.Label("Peso",GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIELements);

		weightUser = GUILayout.TextField (weightUser,5,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		GUILayout.Label("kgs.",GUILayout.ExpandWidth(false));

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();


		GUILayout.BeginHorizontal();

		GUILayout.Space (spaceBetweenGUIELements);
		
		GUILayout.Box (mTextureBalloon,GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIELements);
		
		GUILayout.Label ("Mido");

		GUILayout.Space (spaceBetweenGUIELements);

		heightUser = GUILayout.TextField (heightUser,5,GUILayout.ExpandWidth(false));

		GUILayout.Space (spaceBetweenGUIELements);

		GUILayout.Label("cms.",GUILayout.ExpandWidth(false));

		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();
		

		GUILayout.Space (spaceBetweenGUIELements);
		
		GUILayout.Label ("Mi actividad física es");
		
		GUILayout.Space (spaceBetweenGUIELements);


		//Toggles
		isMuch = GUILayout.Toggle (isMuch, mToggleMuch,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));
//		
		if (isMuch) {
			mToggleMuch = mToggleMuchOn;
			mToggleLow = mToggleLowOff;
			mToggleRegular = mToggleRegularOff;

			isRegular = false;
			isLow = false;
		} else {
			mToggleMuch = mToggleMuchOff;
		}

		GUILayout.Space (1f);

		isRegular = GUILayout.Toggle (isRegular, mToggleRegular,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		if (isRegular) {
			mToggleMuch = mToggleMuchOff;
			mToggleLow = mToggleLowOff;
			mToggleRegular = mToggleRegularOn;

			isMuch = false;
			isLow = false;
		} else {
			mToggleRegular = mToggleRegularOff;
		}
		
		GUILayout.Space (1f);

		isLow = GUILayout.Toggle (isLow, mToggleLow,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		if (isLow) {
			mToggleMuch = mToggleMuchOff;
			mToggleLow = mToggleLowOn;
			mToggleRegular = mToggleRegularOff;
			isRegular = false;
			isMuch = false;
		} else {
			mToggleLow = mToggleLowOff;
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();



		GUILayout.Space((Screen.width/2) - (mTextureButton.width/2));


		if (GUILayout.Button (mTextureButton)) {

			int userAge = PlayerPrefs.GetInt("UserAge");

			int userSex = PlayerPrefs.GetInt("UserSex");

//			TMB = (10 x peso en kg) + (6,25 × altura en cm) - (5 × edad en años) + 5
//				Mujeres	TMB = (10 x peso en kg) + (6,25 × altura en cm) - (5 × edad en años) - 161
			float calories ;

			if(userSex == 1){
				calories = ((10f* float.Parse(weightUser)) + (6.25f*(float.Parse(heightUser))) - (5f* userAge)+5);
			}else
				calories = ((10f* int.Parse(weightUser)) + (6.25f*(int.Parse(heightUser))) - (5f* userAge)-161);

			if(isMuch)
				calories = calories*1.55f;
			else if(isRegular)
				calories =calories * 1.375f;
			else if(isLow)
				calories =calories * 1.22f;


			PlayerPrefs.SetFloat("RecommendedCalories",calories);

			Application.LoadLevel("RegistryFormRecommendation");
		}
		
		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.EndVertical();

		GUILayout.EndArea();

		GUI.skin = null;


	}
	
}
