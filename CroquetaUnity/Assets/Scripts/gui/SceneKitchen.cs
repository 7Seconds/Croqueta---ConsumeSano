using System.Collections;
using UnityEngine;

public class SceneKitchen: MonoBehaviour {
	
	public Texture2D arrowRight;
	
	public Texture2D arrowLeft;
	public Texture2D[] medHappiness;

	public Texture2D[] medEnergy;

	public Texture2D[] medFood;

	public Texture2D[] medWeight;
	private float topSpace = 5f;

	private float buttonSpace = 5f;

	public Texture refrigerator;

	public Texture plate;

	Animator anim;

	public AudioClip roar;

	private int lapse = 20;
	
	static int indexFood;
	
	static int indexHappines;
	
	static int indexEnergy;
	
	static int indexWeight;
	
	private float countDown = 0f;
	
	
	
	void Start(){
		
		indexFood = PlayerPrefs.GetInt("IndexFood");
		
		indexHappines = PlayerPrefs.GetInt("IndexHappines");
		
		indexEnergy = PlayerPrefs.GetInt("IndexEnergy");
		
		indexWeight = PlayerPrefs.GetInt("IndexWeight");
		
	}
	
	
	void OnGUI()
	{
		
		updateIndex ();

		PlayerPrefs.GetInt ("medHapiness");

		GUI.backgroundColor = new Color (0, 0, 0, 0);
		
		if (GUI.Button (new Rect (0, Screen.height / 2 - (arrowRight.height / 2), arrowLeft.width, arrowLeft.height), arrowLeft)) {
			Application.LoadLevel("RoomScene");
				}
		
		if (GUI.Button (new Rect (Screen.width - arrowRight.width, Screen.height / 2 - (arrowRight.height / 2), arrowLeft.width, arrowLeft.height), arrowRight)) {
			Application.LoadLevel("ParkScene");
				}
		
		GUILayout.BeginArea (new Rect (0f, topSpace, Screen.width, topSpace + medEnergy [0].height));						

		GUILayout.BeginHorizontal ();

		GUILayout.FlexibleSpace ();

		GUILayout.Box(medFood[indexFood]);
		
		GUILayout.Box(medEnergy[indexEnergy]);
		
		GUILayout.Box(medHappiness[indexHappines]);
		
		GUILayout.Box(medWeight[indexWeight]);

		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal ();

		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (0f, Screen.height - refrigerator.height- buttonSpace, Screen.width, buttonSpace + refrigerator.height));						

		GUILayout.BeginHorizontal ();

		GUILayout.FlexibleSpace ();

		
		if(GUILayout.Button(refrigerator))
			Application.LoadLevel("SceneRefrigerator");


		GUILayout.Space (80f);

		if (GUILayout.Button (plate)) {
			CrocodrileControllerSript.animEating();
		}


		GUILayout.FlexibleSpace ();

		GUILayout.EndHorizontal ();

		GUILayout.EndArea();

	}    

	
	private void updateIndex(){
		
		countDown += Time.deltaTime;
		
		if(((int)countDown == lapse)){
			countDown = 0f;
			
			if(indexFood < 7){
				indexFood++;
				
				PlayerPrefs.SetInt("IndexFood",indexFood);
			}
			
			if(indexFood > 5){
				if(indexWeight<7)
				{
					indexWeight++;
					PlayerPrefs.SetInt("IndexWeight",indexWeight);
				}
			}
			
			if(indexHappines < 7){
				indexHappines++;
				if(indexHappines > 4)
					CrocodrileControllerSript.animSad(true);
				else
					CrocodrileControllerSript.animSad(false);
				
				PlayerPrefs.SetInt("IndexHappines",indexHappines);
			}
			
			if(indexEnergy < 7){
				indexEnergy++;
				
				PlayerPrefs.SetInt("IndexEnergy",indexEnergy);
				
			}
		}
	}
	
	
	public static void addIndex(int flag, int ammount){
		if (flag == 0 && (indexEnergy-ammount)>=0) 
			indexEnergy = indexEnergy-ammount;
		else if(flag ==1 && (indexFood-ammount)>=0)
			indexFood = indexFood-ammount;
		else if(flag ==2&& (indexHappines-ammount)>=0)
			indexHappines = indexHappines-ammount;
		else if(flag ==3&& (indexHappines-ammount)>=0)
			indexWeight = indexWeight-ammount;
	}
}