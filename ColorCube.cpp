using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour {


	public GameObject[] face;
	public Material [] colors;
	private Renderer rend;

	private int[,] cube = {
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, },
		{ 1, 1, 1, 1, 1, 1, 1, 1, 1, },
		{ 2, 2, 2, 2, 2, 2, 2, 2, 2, },
		{ 3, 3, 3, 3, 3, 3, 3, 3, 3, },
		{ 4, 4, 4, 4, 4, 4, 4, 4, 4, },
		{ 5, 5, 5, 5, 5, 5, 5, 5, 5, }};



	void Start () {

	

		for (int side = 0; side < 6; side++) {
			face[side].

		}
	}
}
