using System.Collections;
using UnityEngine;

public class SelectYourPet: MonoBehaviour {

	public Texture2D mSelectDog;

	public Texture2D mSelectTitleDog;

	public Texture2D mSelectDogArrowLeft;

	public Texture2D mSelectDogArrowRight;

	public Texture2D mSelectHamster;

	public Texture2D mSelectTitleHamster;
	
	public Texture2D mSelectHamsterArrowLeft;
	
	public Texture2D mSelectHamsterArrowRight;

	public Texture2D mSelectCrocodrile;

	public Texture2D mSelectTitleCrocodrile;
	
	public Texture2D mSelectCrocodrileLeft;
	
	public Texture2D mSelectCrocodrileRight;

	public Texture2D mBackground;

	public Texture2D mButtonChoose;
	
	public GUISkin mGuiSkin;

	private int index = 0;

	void OnGUI()
	{

		GUI.backgroundColor = new Color(0,0,0,0);




		GUI.skin = mGuiSkin;

		GUILayout.BeginArea (new Rect (0f, Screen.height * 0.23f, Screen.width, Screen.height * 0.81f));


		if (index == 0){  						
				
				GUILayout.BeginVertical ();
						// Begin the singular Horizontal Group
				GUILayout.BeginHorizontal ();	

				if(GUILayout.Button (mSelectCrocodrileLeft))
							index--;
				
				GUILayout.FlexibleSpace ();

				GUILayout.Box (mSelectTitleCrocodrile);

				GUILayout.FlexibleSpace ();

				if(GUILayout.Button (mSelectCrocodrileRight))
							index++;
				
				GUILayout.EndHorizontal ();


			GUILayout.BeginHorizontal ();	
			
			GUILayout.FlexibleSpace ();
			
			GUILayout.Box (mSelectCrocodrile);

			GUILayout.BeginVertical();
			
			GUILayout.FlexibleSpace ();
			
			GUILayout.Label("Cocodrilo valiente y feroz.");
			
			GUILayout.Label("Te protegerá siempre");

			GUILayout.FlexibleSpace ();
			
			GUILayout.BeginHorizontal ();
			
			GUILayout.FlexibleSpace ();
			
			if(GUILayout.Button(mButtonChoose)){
				Application.LoadLevel("SelectPetDetail");
			}
			
			GUILayout.FlexibleSpace ();
			
			GUILayout.EndHorizontal ();

			GUILayout.FlexibleSpace ();

			GUILayout.EndVertical ();

			GUILayout.EndHorizontal ();

			GUILayout.EndVertical ();
				}


		if (index == -1) {
								
			GUILayout.BeginVertical ();
			// Begin the singular Horizontal Group
			GUILayout.BeginHorizontal ();	
			
			if(GUILayout.Button (mSelectHamsterArrowLeft))
			{index= 1;}
			GUILayout.FlexibleSpace ();
			
			GUILayout.Box (mSelectTitleHamster);
			
			GUILayout.FlexibleSpace ();
			
			if(GUILayout.Button (mSelectHamsterArrowRight))
				index++;
			
			
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();	
			
			GUILayout.FlexibleSpace ();
			
			GUILayout.Box (mSelectHamster);
			
			GUILayout.FlexibleSpace ();

			GUILayout.BeginVertical();

			GUILayout.FlexibleSpace ();
			GUILayout.Label("El hamster, es animado, pequeño y te ayudará siempre.");
			

			GUILayout.FlexibleSpace ();

			GUILayout.EndVertical ();

			GUILayout.FlexibleSpace ();
			
			GUILayout.EndHorizontal ();

			GUILayout.FlexibleSpace ();


			
			GUILayout.EndVertical ();

				}

		if (index == 1) {

			GUILayout.BeginVertical ();
				// Begin the singular Horizontal Group
				GUILayout.BeginHorizontal ();	
					
					if(GUILayout.Button (mSelectDogArrowLeft))
							index--;
					
					GUILayout.FlexibleSpace ();
								
					GUILayout.Box (mSelectTitleDog);
								
					GUILayout.FlexibleSpace ();
					
					if(GUILayout.Button (mSelectDogArrowRight))
						index=-1;
										
				GUILayout.EndHorizontal ();

				GUILayout.BeginHorizontal ();	

					GUILayout.FlexibleSpace ();

					GUILayout.Box (mSelectDog);

					GUILayout.FlexibleSpace ();

					GUILayout.BeginVertical();

						GUILayout.FlexibleSpace ();

						GUILayout.Label("El Perro, un amigo fiel, te acompañará siempre en lo que necesites");

						GUILayout.FlexibleSpace ();

					GUILayout.EndVertical ();

					GUILayout.FlexibleSpace ();

				GUILayout.EndHorizontal ();

			GUILayout.EndVertical ();

				}

		GUILayout.EndArea();

	
	}	
}
