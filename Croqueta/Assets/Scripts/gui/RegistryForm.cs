using UnityEngine;
using System.Collections;

public class RegistryForm: MonoBehaviour {

	public Texture2D mTexturePencil;

	public Texture2D mTextureFace;

	public Texture2D mTextureCake;
	
	public Texture2D mTextureButton;

	public Texture2D mTextureToggleMOn;

	public Texture2D mTextureToggleMOff;

	private Texture2D mTextureToggleM;
	
	public Texture2D mTextureToggleFOn;

	public Texture2D mTextureToggleFOff;

	private Texture2D mTextureToggleF;
	
	private string nameUser = "nombre";

	private string ageUser = "edad";

	public GUISkin mGuiSkin;

	bool isFemale = false;

	bool isMale = false;

	void OnGUI()
	{

		GUI.skin = mGuiSkin;

		GUI.backgroundColor = new Color(0,0,0,0);

		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0f,Screen.height*0.25f,Screen.width,Screen.height*0.81f));

		GUILayout.BeginVertical();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		GUILayout.Space (20f);

		GUILayout.Box(mTexturePencil,GUILayout.ExpandWidth(false));

		GUILayout.Space (20f);

		GUILayout.Label("Mi nombre es",GUILayout.ExpandWidth(false));

		GUILayout.Space (20f);

		nameUser = GUILayout.TextField (nameUser,50,GUILayout.ExpandWidth(false));

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		GUILayout.Space (20f);
		
		GUILayout.Box (mTextureFace,GUILayout.ExpandWidth(false));

		GUILayout.Space (20f);
		
		GUILayout.Label ("Yo soy");

		GUILayout.Space (20f);

		isMale = GUILayout.Toggle (isMale, mTextureToggleM,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		if (isMale) {
			mTextureToggleM = mTextureToggleMOn;
			mTextureToggleF = mTextureToggleFOff;
			isFemale = false;
		} else {
			mTextureToggleM = mTextureToggleMOff;
		}

		GUILayout.Space (20f);
		
		isFemale = GUILayout.Toggle (isFemale, mTextureToggleF,GUILayout.ExpandWidth(false),GUILayout.ExpandHeight(false));

		if (isFemale) {
			mTextureToggleF = mTextureToggleFOn;
			mTextureToggleM = mTextureToggleMOff;
			isMale = false;
		} else {
			mTextureToggleF = mTextureToggleFOff;
		}

		
		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();


		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		GUILayout.Space (20f);

		GUILayout.Box (mTextureCake,GUILayout.ExpandWidth(false));

		GUILayout.Space (20f);
		
		GUILayout.Label ("Mi edad");

		GUILayout.Space (20f);
		
		ageUser = GUILayout.TextField (ageUser,50,GUILayout.ExpandWidth(false));
		
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();

		GUILayout.Space((Screen.width/2) - (mTextureButton.width/2));

		if (GUILayout.Button (mTextureButton)) {

			PlayerPrefs.SetString("UserName", nameUser);

			PlayerPrefs.SetInt("UserAge", int.Parse(ageUser));

			if(isMale)
				PlayerPrefs.SetInt("UserSex",1);
			else
				PlayerPrefs.SetInt("UserSex",0);

			Application.LoadLevel("RegistryFormWeight");
		}
		
		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace ();

		GUILayout.EndVertical();

		GUILayout.EndArea();

		GUI.skin = null;


	}
	
}
