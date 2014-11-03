using System.Collections;
using UnityEngine;

public class ScenePedometer: MonoBehaviour {
	
	public Texture2D arrowRight;
	
	public Texture2D arrowLeft;

	public Texture2D[] medHappiness;

	public Texture2D[] medEnergy;

	public Texture2D[] medFood;

	public Texture2D[] medWeight;

	private float topSpace = 5f;

	private float buttonSpace = 5f;

	public Texture buttonBack;

	public Texture backgroundBox;

	public GUISkin mGuiSkin;

	public GUISkin mGuiSkinHighlight;


	float oldValue;

	float x_old = 0;
	float y_old = 0;
	float z_old = 0;
	bool hasChanged = true;

	int counter = 0;
	
	void OnGUI()
	{
		GUI.skin = mGuiSkin;


		GUI.Box( new Rect( Screen.width*0.3f, 0, Screen.width*0.4f, 100 ), backgroundBox);
		
		GUILayout.BeginArea (new Rect (0f, topSpace, Screen.width, topSpace + (Screen.height*0.3f)));						
		
		GUILayout.BeginHorizontal ();
		
		GUILayout.FlexibleSpace ();

		GUILayout.BeginVertical ();
			GUILayout.BeginHorizontal ();
				GUILayout.FlexibleSpace ();
				GUILayout.Label("Número de  pasos ");
			GUI.skin = mGuiSkinHighlight;
			GUILayout.Label(" " + counter);
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

		GUILayout.EndVertical ();

		GUILayout.FlexibleSpace ();
		
		GUILayout.EndHorizontal ();
		
		GUILayout.EndArea();

		GUI.skin = null;


		GUI.backgroundColor = new Color (0, 0, 0, 0);						

		GUILayout.BeginArea (new Rect (0f, Screen.height - buttonBack.height- buttonSpace, Screen.width, buttonSpace + buttonBack.height));						

		GUILayout.BeginHorizontal ();

		GUILayout.FlexibleSpace ();


		GUILayout.Space (80f);
		if (GUILayout.Button (buttonBack)) {

			PlayerPrefs.SetInt("StepNumber",counter);
				Application.LoadLevel ("CalorieCounter");				

				}

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal ();

		GUILayout.EndArea();
	}    


	// Update is called once per frame
	void Update () {
		checkIsMouvement ();
	}




	private void checkIsMouvement()
	{
		float x = Input.acceleration.x;
		float y = Input.acceleration.y;
		float z = Input.acceleration.z;

		 oldValue = ((x_old * x) + (y_old * y)) + (z_old * z);
		float oldValueSqrT = Mathf.Abs(Mathf.Sqrt( (((x_old * x_old) + (y_old * y_old)) + (z_old * z_old))));

		float newValue = Mathf.Abs(Mathf.Sqrt( (((x * x) + (y * y)) + (z * z))));

		oldValue = oldValueSqrT * newValue;

		if ((oldValue <= 0.85) && (oldValue > 0.8))
		{
			if (!hasChanged)
			{
				hasChanged = true;
				counter++; //here the counter
			}
			else
			{
				hasChanged = false;
			}
		}

		x_old = x;
		y_old = y;
		z_old = z;
	}



}