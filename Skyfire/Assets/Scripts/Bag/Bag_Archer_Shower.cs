﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag_Archer_Shower : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = " "+Bag_Archer.b_archer;
	}
}