using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour
{

	public AudioSource Audio;

	private float _maxVol;

	void Start(){
	}

	public void begin()
	{
		
		_maxVol = 1.0f;
		SetAudioTimePosition(20.0f);
//		Play ();

		StartCoroutine(fadeIn());
//		Audio.Play(44100);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}


	public void Play(){
		Audio.Play();
	}

	public void Pause(){
		Audio.Pause ();
	}

	public void SetAudioTimePosition(float time){
		Audio.time = time;
	}

	public int getCurrentTime(){
		return (int) Audio.time * 1000;
	}

	IEnumerator fadeIn()
	{
		Audio.volume = 0.0f;
		Audio.Play ();
		Audio.loop = true;
		float t = 0.0f;
		while (t < _maxVol) {
			t += Time.deltaTime;
			Audio.volume = t;
			yield return new WaitForSeconds(0);
		}
	}
}

