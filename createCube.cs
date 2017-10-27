using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {
	


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

	private float[,] transformations={
		{0,1.5f,0	,0,0,0,0},		
		{2,-1.5f,0	,0,0,180,0},	
		{-.5f,-1,0	,0,0,90,90},		

		{2.5f,1,0	,0,0,-90,90},
		{0,1,2.5f		,90,0,0,90},
		{0,-1,-.5f		,90,0,0,-90}
	}; 

	void Start () {

		GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
		plane.gameObject.transform.localScale = new Vector3(.1f,.1f,.1f);

		for (int side = 0; side < 6; side++) {
			face [side] = Instantiate (new GameObject(), new Vector3 (0, 0, 0), new Quaternion (0, 0, 0, 0));
			face [side].name = "Face " + side.ToString ();
			face [side].transform.parent = this.transform;
			for (int x = 0; x < 3; x++) { 
				for (int y = 0; y < 3; y++) {
					var cubeletFace = Instantiate (plane, new Vector3 (x, 0, y), new Quaternion (0, 0, 0, 0));	
					rend = cubeletFace.GetComponent<MeshRenderer> ();
					rend.material = colors [cube [side, x * 3 + y]];
					cubeletFace.name = "Plane " + side.ToString () + x.ToString () + y.ToString ();
					cubeletFace.transform.parent = face [side].transform;
				}
			}
			face [side].transform.position = new Vector3 (transformations [side, 0], transformations [side, 1], transformations [side, 2]);
			face[side].transform.rotation = new Quaternion(transformations[side,3],transformations[side,4],transformations[side,5],transformations[side,6]);
		}
	}
}
