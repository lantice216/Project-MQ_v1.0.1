﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class onUIForHWasScreen : MonoBehaviour {
    public RectTransform RTF;
	// Use this for initialization
	void Start () {
        RTF.sizeDelta = new Vector2(Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}