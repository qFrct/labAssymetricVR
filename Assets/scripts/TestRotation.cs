﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour {

    public GameObject murReference;

    private Mur murChoisi;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump"))
        {
            murChoisi = CreeNiveau.renvoieMur(murReference);
            BougeCameraRig bouge = GetComponent<BougeCameraRig>();
            bouge.choisitPiece(murChoisi);
        }
	}
}
