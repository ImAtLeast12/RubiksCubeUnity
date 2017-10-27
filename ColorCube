using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour {

	private createCube cCube= GetComponent<createCube>();


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
		createCube cCube= this.GetComponent<createCube>();

		face = cCube.face;
	}
}
