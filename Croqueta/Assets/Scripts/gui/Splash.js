#pragma strict

function Start () {

yield WaitForSeconds (2);

Application.LoadLevel("Registry");

PlayerPrefs.DeleteAll();

}
