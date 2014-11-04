using System.Collections;
using UnityEngine;

public class SceneThrophies: MonoBehaviour {

	public Texture buttonBack;


	void OnGUI()
	{

		GUI.backgroundColor = new Color (0, 0, 0, 0);
		
		if (GUI.Button (new Rect (Screen.width/2 - (buttonBack.height / 2), Screen.height - (buttonBack.height + 10f), buttonBack.width, buttonBack.height), buttonBack)) {
			Application.LoadLevel("RoomScene");
				}
	

	}    
}