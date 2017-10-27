using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateFace : MonoBehaviour {
	private float[,] transformations={
		{0,1.5f,0	,0,0,0,0},		
		{2,-1.5f,0	,0,0,180,0},	
		{-.5f,-1,0		,0,0,90,90},		

		{0,0,0		,0,0,0,0},
		{0,0,0		,0,0,0,0},
		{0,0,0		,0,0,0,0}
	}; 

	public int side;
	void Start () {
		
	}
}
