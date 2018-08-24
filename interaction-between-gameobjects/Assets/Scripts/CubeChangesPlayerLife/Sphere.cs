using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {


	public int playerLife = 10;

	public Texture text;

	void OnGUI(){

		GUILayout.Label (text);
		GUILayout.Label ("Quedan " + playerLife + "vida (s). ");

	}

	public void ChangeLife(){

		playerLife = playerLife - 1;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
