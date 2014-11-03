using System.Collections;
using UnityEngine;

public class SelectYourPetDetail: MonoBehaviour {

	public Texture2D mSelectCrocodrile;

	public Texture2D mSelectPetButton;

	public Texture2D mBackground;

	public Texture2D mButtonChoose;

	public Texture2D mPutInName;

	public GUISkin mGuiSkin;

	private string characterName = "Nombre";

	void OnGUI()
	{

		GUI.backgroundColor = new Color(0,0,0,0);

		GUI.skin = mGuiSkin;

		GUILayout.BeginArea (new Rect (0f, Screen.height * 0.23f, Screen.width, Screen.height * 0.81f));

		GUILayout.BeginVertical ();
			
		GUILayout.BeginHorizontal ();	
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.Box (mSelectCrocodrile);

		GUILayout.FlexibleSpace ();
		
		GUILayout.EndHorizontal ();

		GUILayout.FlexibleSpace ();
		
		GUILayout.BeginHorizontal ();
		
		GUILayout.FlexibleSpace ();
		
		if (GUILayout.Button (mButtonChoose)) {
			Application.LoadLevel("RoomScene");

				}
		
		GUILayout.FlexibleSpace ();
		
		GUILayout.EndHorizontal ();

		GUILayout.FlexibleSpace ();

		GUILayout.EndVertical ();

		GUILayout.EndArea();

		GUI.Box(new Rect(Screen.width/2, Screen.height * 0.23f, mPutInName.width, mPutInName.height), mPutInName);

		characterName = GUI.TextField(new Rect((Screen.width/2-180), (Screen.height * 0.23f)+75, mPutInName.width, mPutInName.height), characterName, 25);

		GUI.skin = null;
	}	
}
