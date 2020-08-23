/*
 * AUTHOR: SHAWN GRANT
 * PURPOSE: PLAY, PAUSE
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

	// Use this for initialization
	public GameObject pause;
	GlobalInteractions inputActions;
	bool paused;

	private void Awake()
	{
		inputActions = new GlobalInteractions();
	}
	private void OnEnable()
	{
		inputActions.Enable();
	}
	private void OnDisable()
	{
		inputActions.Disable();
	}

	void Update(){
		if (inputActions.Default.Pause.triggered) {
			if (paused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}

	void OnApplicationPause(bool paused)
	{
		if (paused) {
			Pause ();
		}
	}

	public void Pause(){
		pause.SetActive (true);
		paused = true;
		Time.timeScale = 0f;
	}

	public void Resume(){
		pause.SetActive (false);
		paused = false;
		Time.timeScale = 1;
	}

}
