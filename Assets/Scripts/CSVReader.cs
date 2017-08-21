using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 

public class CSVReader : MonoBehaviour 
{

	// splits a CSV file into a 2D string array
	static public List<SentenceData> CSVtoData(string csvText)
	{
		List<SentenceData> data = new List<SentenceData>();

		string[] lines = csvText.Split("\n"[0]); 

		for (int i = 1; i < lines.Length; i++)
		{
			if (lines [i] != "") {
				string[] row = lines[i].Split("~"[0]);
				data.Add (new SentenceData ( row [0], row [1], int.Parse(row [2]) ) );
			}
		}
		return data; 
	}
}


public struct SentenceData {

	public string sentenceEng, sentenceRus;
	public int startTime;

	public SentenceData(string _sentenceEng, string _sentenceRus, int _startTime)
	{
		sentenceEng = _sentenceEng;
		sentenceRus = _sentenceRus;
		startTime = _startTime;
	}
}