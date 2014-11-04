using UnityEngine;
using System.Collections;

public class Pedometer : MonoBehaviour {

	float x_old = 0f;

	float y_old = 0f;

	float z_old = 0f;

	// Use this for initialization
	void Start () {

		x_old = Input.acceleration.x;

		y_old = Input.acceleration.y;

		z_old = Input.acceleration.z;
	
	}
	
	// Update is called once per frame
	void Update () {

		checkIsMouvement ();
	
	}

	private bool hasChanged;
	private int counter;
	
	private void checkIsMouvement()
	{
		float x = Input.acceleration.x;
		float y = Input.acceleration.y;
		float z = Input.acceleration.z;
		double oldValue = ((x_old * x) + (y_old * y)) + (z_old * z);


		float oldValueSqrT = Mathf.Abs(Mathf.Sqrt( (((x_old * x_old) + (y_old * y_old)) + (z_old * z_old))));
		float newValue = Mathf.Abs(Mathf.Sqrt( (((x * x) + (y * y)) + (z * z))));
		oldValue /= oldValueSqrT * newValue;
		if ((oldValue <= 0.994) && (oldValue > 0.9))
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
