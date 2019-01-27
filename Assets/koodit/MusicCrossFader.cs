using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCrossFader : MonoBehaviour
{
	public stat statReference;
	public AudioSource music0;
	public AudioSource music1;
	public float FadeSpeed = 0.5f;

	private int currentMusic;


	void Start()
	{
		music0.Play();
		music1.Play();

		music0.volume = 0.0f;
		music1.volume = 1.0f;

		currentMusic = 1;
	}

	void Update ()
	{
		var dt = Time.deltaTime;

		var ratio = statReference.MyCurrentValue / statReference.MyMaxValue;
		currentMusic = ratio >= 0.5 ? 1 : 0;

		if(currentMusic == 0)
		{
			music0.volume = Mathf.Min(1.0f, music0.volume + FadeSpeed * dt);
			music1.volume = Mathf.Max(0.0f, music1.volume - FadeSpeed * dt);

		}
		else
		{
			music0.volume = Mathf.Max(0.0f, music0.volume - FadeSpeed * dt);
			music1.volume = Mathf.Min(1.0f, music1.volume + FadeSpeed * dt);
		}
	}
}
