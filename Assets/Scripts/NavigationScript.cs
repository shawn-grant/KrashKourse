/*
 * AUTHOR: SHAWN GRANT
 * PURPOSE: CONTROLS FADING BETWEEN SCENES; IS ATTACHED TO THE SceneTransitioner PREFAB
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour {

	Animator ScreenAnim;
	string sceneName;

	void Start(){
		ScreenAnim = GetComponent<Animator> ();
	}

	public void LoadScene(string Sname){
		Time.timeScale = 1;
		sceneName = Sname;
		ScreenAnim.SetTrigger ("TriggerFadeOut");
	}

	public void Restart (){
		Time.timeScale = 1;
		sceneName = gameObject.scene.name;
		ScreenAnim.SetTrigger ("TriggerFadeOut");
	}

	public void Load(){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

	public void Hide(){
		GetComponent<Canvas> ().sortingOrder = -1;
		transform.GetChild(0).gameObject.SetActive(false);
	}
	public void Show(){
		GetComponent<Canvas> ().sortingOrder = 10;
		transform.GetChild(0).gameObject.SetActive(true);
	}

}
