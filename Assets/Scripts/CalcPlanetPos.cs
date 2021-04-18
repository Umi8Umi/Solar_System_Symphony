using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using System.Globalization;

public class CalcPlanetPos : MonoBehaviour
{
	public TextAsset coordinates;
	public int moveSpeed = 1;

	string[] coordinatesArray;
	int currentPointIndex = 0;
	Vector3 destinationVector;

	public GameObject endGameUI;

	void Start()
	{
		coordinatesArray = coordinates.text.Split(new char[] { '\n' });
		InvokeRepeating("ChangePlanetPos", 0.0f, 0.01f);
	}

	void ChangePlanetPos()
	{
		if (destinationVector == null || transform.position == destinationVector)
		{
			currentPointIndex = currentPointIndex < coordinatesArray.Length - 1 ? currentPointIndex + 1 : -1;
			if (currentPointIndex == -1)
			{
				currentPointIndex = 0;
				CancelInvoke();
				Time.timeScale = 0;
				endGameUI.SetActive(true);
				StopAllAudio();
			}
			if (!string.IsNullOrWhiteSpace(coordinatesArray[currentPointIndex]))
			{
				string[] xyz = coordinatesArray[currentPointIndex].Split(new char[] { ',' });
				destinationVector = new Vector3(float.Parse(xyz[0]), float.Parse(xyz[1]), float.Parse(xyz[1]));
			}
		}
		else
		{
			transform.position = destinationVector;
		}
	}

	private AudioSource[] allAudioSources;

	void StopAllAudio()
	{
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach (AudioSource audioS in allAudioSources)
		{
			audioS.Stop();
		}
	}
}
