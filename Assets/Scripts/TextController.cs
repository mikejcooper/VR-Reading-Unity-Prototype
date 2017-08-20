using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

	public Text TextCanvas;

	private Dictionary<double, string> _dictionary = new Dictionary<double, string>();


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

		if ( _dictionary.ContainsKey(key) ) {
			OnChangeText (_dictionary [key]);
		}
	}

	public void LoadDictionary(List<SentencePacketData> data){
		foreach (var data_i in data) {
			_dictionary.Add (data_i.startTime, data_i.sentenceEng);
		}
	}
		

	private void OnChangeText(string text){
		TextCanvas.text = text;
	}






}
