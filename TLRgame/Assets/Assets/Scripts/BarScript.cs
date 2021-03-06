﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    public Player player;

    public Text valueText;

    public Image content;

    public float fillAmount;
    public float MaxValue { get; set; }

    public float Value
    {
		set
        {
			    string[] tmp = valueText.text.Split(':');
			    valueText.text = tmp[0] + ": " + value;
			    fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

	// Use this for initialization
	void Start ()
    {

	}

	// Update is called once per frame
	void Update ()
    {
		HandleBar();
	}

	private void HandleBar()
    {
		if (fillAmount != content.fillAmount)
        {
				content.fillAmount = fillAmount;
		}
	}

	private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
