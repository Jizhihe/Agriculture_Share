using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	Vector3 v = new Vector3 (1,0,0);

	void Update () {

		    transform.position += v * Time.deltaTime * 3;
		if (transform.position.x >= 9 ) {

			transform.localScale =new Vector3 (-1, 1, 1);
			v = -v;
			transform.position += v * Time.deltaTime * 3;

		}
		if (transform.position .x <= -9) {

			transform.localScale = new Vector3 (1, 1, 1);
			v = -v;
			transform.position += v * Time.deltaTime * 3;
		}
	}



}
