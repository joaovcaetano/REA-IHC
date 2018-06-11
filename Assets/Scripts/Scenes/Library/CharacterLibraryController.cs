﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterLibraryController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void backToLibraryMenu(){
		SceneManager.LoadScene ("Library");
	}
	public void goToJavierLibrary(){
		SceneManager.LoadScene("JavierLibrary");
	}
	public void goToCarlLibrary(){
		SceneManager.LoadScene("CarlLibrary");
	}
	public void goToMaryLibrary(){
		SceneManager.LoadScene("MaryLibrary");
	}
}
