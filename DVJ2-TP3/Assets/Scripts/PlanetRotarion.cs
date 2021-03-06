﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotarion : MonoBehaviour {
    public GameObject RotateAround;
    private float Radius;
    public float TraslationSpeed;
    public float Angle;
    public float RotationSpeed;
    // Use this for initialization
    void Start () {

		Radius = Mathf.Sqrt((transform.position.x - RotateAround.transform.position.x *
            transform.position.x - RotateAround.transform.position.x) + 
            (transform.position.z - RotateAround.transform.position.x *
            transform.position.z - RotateAround.transform.position.x));
        TraslationSpeed += Random.Range(-5, 5);
        if (TraslationSpeed <= 0)
            TraslationSpeed = 1;
	}
	
	// Update is called once per frame
	void Update () {
        Angle += TraslationSpeed * Time.deltaTime;
        Vector3 newPos = Vector3.zero;
        newPos.x = RotateAround.transform.position.x + Radius * Mathf.Cos(Angle * Mathf.Deg2Rad);
        newPos.z = RotateAround.transform.position.z + Radius * Mathf.Sin(Angle * Mathf.Deg2Rad);
        transform.position = newPos;       
        transform.Rotate(transform.up * RotationSpeed * Time.deltaTime);
    }
}
