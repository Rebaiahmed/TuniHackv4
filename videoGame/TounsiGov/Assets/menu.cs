using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void play(){
				  SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

	}
	 public void leaderboard(){
		  SceneManager.LoadScene("scene1", LoadSceneMode.Single);
	 }

}
