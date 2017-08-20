using UnityEngine;
using System.Collections;

public class AudioTextController : MonoBehaviour 
{

	public TextAsset CSV; 
	public TextController textController;

	private AudioController audioController;



	// Use this for initialization
	void Start () {
		audioController = new AudioController ();

		textController.LoadDictionary( CSVReader.CSVtoData(CSV.text) ) ; 
			
	}
	
	// Update is called once per frame
	void StartFromTimeX () {


	}
}

