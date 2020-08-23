using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.1f;
	public AudioClip typeSound1;
	public AudioClip typeSound2;

	string message;
    TextMeshProUGUI textCompTMP;

	public float StartDelay;
	public bool autoStart;

    [HideInInspector]
    public bool doneTyping;

	// Use this for initialization
	void Start () {
		textCompTMP = GetComponent<TextMeshProUGUI> ();

		if(autoStart)
			StartCoroutine(Delay ());
	}

	IEnumerator Delay () {
		message = textCompTMP.text;
		textCompTMP.text = "";
		yield return new WaitForSeconds (StartDelay);
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
        doneTyping = false;
		foreach (char letter in message.ToCharArray()) {
			textCompTMP.text += letter;
			yield return new WaitForSeconds (letterPause);
		}
        doneTyping = true;
	}

}
