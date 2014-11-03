using UnityEngine;
using System.Collections;

public class AddFoodScene: MonoBehaviour {
	
	public Texture2D mTextureButton;
		
	public Texture2D mToggleBreadOn;

	public Texture2D mToggleMilkOn;

	private Texture2D mToggleMilk;

	private Texture2D mToggleBread;

	private Texture2D mToggleMeat;

	public Texture2D mToggleMeatOn;

	public Texture2D mToggleBreadOff;
	
	public Texture2D mToggleMilkOff;
	
	public Texture2D mToggleMeatOff;



	public GUISkin mGuiSkin;

	bool isMeat = false;

	bool isBread = false;

	bool isMilk = false;

	int icon = 0;


	private string foodName = "alimento";

	private string calories = "calories";

	private string foodGroup = "grupo";

	private string portion = "porción";

	void OnGUI()
	{

		GUI.skin = mGuiSkin;

		GUI.backgroundColor = new Color(0,0,0,0);

		GUILayout.BeginArea (new Rect (0f,0f,Screen.width,Screen.height));

		GUILayout.BeginVertical();

		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();											

			GUILayout.Space (20f);

			GUILayout.Label("Nombre",GUILayout.ExpandWidth(false));

			GUILayout.Space (20f);

			foodName = GUILayout.TextField (foodName,50,GUILayout.ExpandWidth(false));

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();											
			
			GUILayout.Space (20f);
			
			GUILayout.Label("Calorias",GUILayout.ExpandWidth(false));
			
			GUILayout.Space (20f);
			
			calories = GUILayout.TextField (calories,50,GUILayout.ExpandWidth(false));
		
		GUILayout.EndHorizontal();

		
		GUILayout.FlexibleSpace ();

		
		GUILayout.BeginHorizontal();											
		
			GUILayout.Space (20f);
			
			GUILayout.Label("ml/gr",GUILayout.ExpandWidth(false));
			
			GUILayout.Space (20f);
			
			portion = GUILayout.TextField (portion,50,GUILayout.ExpandWidth(false));
			
			GUILayout.EndHorizontal();
			

		
		GUILayout.FlexibleSpace ();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		GUILayout.Space (20f);
		
		GUILayout.Label ("Icono");

		GUILayout.Space (20f);

		
		//Toggles
		isMeat = GUILayout.Toggle (isMeat, mToggleMeat,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));
		//		
		if (isMeat) {
			icon = 6;
			foodGroup = "Origen animal";
			mToggleMeat = mToggleMeatOn;
			mToggleMilk = mToggleMilkOff;
			mToggleBread = mToggleBreadOff;
			
			isBread = false;
			isMilk = false;
		} else {
			mToggleMeat = mToggleMeatOff;
		}
		
		GUILayout.Space (1f);
		
		isBread = GUILayout.Toggle (isBread, mToggleBread,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));
		
		if (isBread) {
			icon = 9;
			foodGroup = "Panadería";
			mToggleMeat = mToggleMeatOff;
			mToggleMilk = mToggleMilkOff;
			mToggleBread = mToggleBreadOn;
			
			isMeat = false;
			isMilk = false;
		} else {
			mToggleBread = mToggleBreadOff;
		}
		
		GUILayout.Space (1f);
		
		isMilk = GUILayout.Toggle (isMilk, mToggleMilk,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));
		
		if (isMilk) {
			foodGroup = "Productos lacteos";
			mToggleMeat = mToggleMeatOff;
			mToggleMilk = mToggleMilkOn;
			mToggleBread = mToggleBreadOff;
			isMeat = false;
			isBread = false;
			icon = 13;
		} else {
			mToggleMilk = mToggleMilkOff;
		}

	
		GUILayout.Space (20f);

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();											
		
		GUILayout.Space (20f);
		
		GUILayout.Label("Grupo Alimenticio:",GUILayout.ExpandWidth(false));
		
		GUILayout.Space (20f);

		GUILayout.Label(foodGroup,GUILayout.ExpandWidth(false));

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.BeginHorizontal();

		GUILayout.Space((Screen.width/2) - (mTextureButton.width/2));

		if (GUILayout.Button (mTextureButton)) {

			PlayerPrefs.SetString("nameFood",foodName);

			PlayerPrefs.SetString("calories",foodName);

			PlayerPrefs.SetString("portion",foodName);

			PlayerPrefs.SetInt("icon",icon);

			PlayerPrefs.SetString("foodGroup",foodGroup);

			Application.LoadLevel("SceneRefrigerator");
		}

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();



		GUILayout.EndVertical();

		GUILayout.EndArea();



		GUI.skin = null;



	}
	
}
