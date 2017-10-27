using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFace : MonoBehaviour {
	public GameObject face;
	public Material [] colors;
	private Renderer rend;
	public int side;

	private int[,] cube = {
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, },
		{ 1, 1, 1, 1, 1, 1, 1, 1, 1, },
		{ 2, 2, 2, 2, 2, 2, 2, 2, 2, },
		{ 3, 3, 3, 3, 3, 3, 3, 3, 3, },
		{ 4, 4, 4, 4, 4, 4, 4, 4, 4, },
		{ 5, 5, 5, 5, 5, 5, 5, 5, 5, }};

	private float[,] transformations={
		{0,1.5f,0	,0,0,0,0},		
		{2,-1.5f,0	,0,0,180,0},	
		{-.5f,-1,0	,0,0,90,90},		

		{2.5f,1,0	,0,0,-90,90},
		{0,1,2.5f		,90,0,0,90},
		{0,-1,-.5f		,90,0,0,-90}
	}; 

	void Start () {
		for (int x = 0; x < 3; x++){ 
			for (int y = 0; y < 3; y++){
			var cubeletFace = Instantiate (face,new Vector3(x,0,y),new Quaternion(0,0,0,0));	
				rend = cubeletFace.GetComponent<MeshRenderer>();
				rend.material = colors [cube[side,x*3+y]];
				cubeletFace.name = "Plane " + side.ToString() + x.ToString() + y.ToString();
				cubeletFace.transform.parent = this.transform;
			}
		}


		this.transform.position = new Vector3 (transformations[side,0], transformations[side,1], transformations[side,2]);
		this.transform.rotation = new Quaternion (transformations[side,3],transformations[side,4],transformations[side,5],transformations[side,6]);
	}
}
