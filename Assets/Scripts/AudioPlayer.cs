using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{

	public AudioSource Audio;

	private float _maxVol;


	void Start()
	{
		_maxVol = 1.0f;
//		SetAudioTimePosition(13.21f);
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

