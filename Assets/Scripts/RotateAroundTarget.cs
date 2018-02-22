using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour {

    public Vector3 axis;

    public Transform target;

    public int speed;

	void Start () {
		
	}
	
	void Update () {

        transform.RotateAround(target.position, axis, speed * Time.deltaTime);		
	}
}
