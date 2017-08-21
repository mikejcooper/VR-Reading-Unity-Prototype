using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

	public Text TextCanvas;

	private List<SentenceData> data = new List<SentenceData>();

	private string textHolder = "";


//	private string[] _sentences = [
//		"When I wake up, the other side of the bed is cold.", 
//		"My fingers stretch out, seeking Prim’s warmth but finding only the rough canvas cover of the mattress.", 
//		"She must have had bad dreams and climbed in with our mother.",
//		"Of course she did. This is the day of the reaping."
//	];

	// Use this for initialization
	void Start () {
		OnChangeText ("testing 123");


		double key = 0.02;

//		if ( _dictionary.ContainsKey(key) ) {
//			OnChangeText (_dictionary [key]);
//		}
	}

	public void LoadDictionary(List<SentenceData> _data){
		data = _data; 

		print (data [0].startTime);
		print (data [1].startTime);
		print (data [2].startTime);
	}
		

	private void OnChangeText(string text){
		textHolder = text;
		StartCoroutine(fadeInOut(text));
	}

	IEnumerator fadeInOut(string text)
	{
		print ("fade");
		float fadeDuration = 0.9f;
		TextCanvas.CrossFadeAlpha(0.0f, fadeDuration, false);
		yield return new WaitForSeconds(fadeDuration);
		TextCanvas.text = text;
		TextCanvas.CrossFadeAlpha(1.0f, fadeDuration, false);
	}

	public void showTextNearestToTimeT(int T){

		string text = "";

		int fadeAmount = 1100;

		for (int i = 0; i < data.Count; i++) {
			if (T <= data [0].startTime) {
				text = data[0].sentenceEng; break;
			}
			if (data [i].startTime - fadeAmount <= T && T < data [i + 1].startTime - fadeAmount) {
				text = data [i].sentenceEng; break;
			}
			if (T >= data [data.Count - 1].startTime) {
				text = data[data.Count - 1].sentenceEng; break;
			}
		}

		if (text != textHolder) {
			OnChangeText (text);
		}
	}






}

