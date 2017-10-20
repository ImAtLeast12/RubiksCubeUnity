using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour {

	public GameObject cubelet;

	int[,] cube = new int[,] { 	{ 	0,0,0,
									0,0,0,
									0,0,0, }, 
		
								{ 	1,1,1,
									1,1,1,
									1,1,1, }, 
		
								{ 	2,2,2,
									2,2,2,
									2,2,2, }, 
		
								{ 	3,3,3,
									3,3,3,
									3,3,3, },
		
								{ 	4,4,4,
									4,4,4,
									4,4,4, },
		
								{ 	5,5,5,
									5,5,5,
									5,5,5, }};


	string printCube(){
		string total = "";
		for (int i = 0; i < 3; i++) 
			total += System.String.Format("\t{0},{1},{2},\n", cube[0,3*i], cube[0,1+ (3*i)], cube[0,+ (3*i)]);
		total += "\n";
		for (int i = 0; i < 3; i++) 
			total += System.String.Format ("{0},{1},{2},    {3},{4},{5},    {6},{7},{8},    {9},{10},{11},\n", cube [1, 0 + (3 * i)], cube [1, 1 + (3 * i)], cube [1, 2 + (3 * i)], cube [2, 0 + (3 * i)], cube [2, 1 + (3 * i)], cube [2, 2 + (3 * i)], cube [3, 0 + (3 * i)], cube [3, 1 + (3 * i)], cube [3, 2 + (3 * i)], cube [4, 0 + (3 * i)], cube [4, 1 + (3 * i)], cube [4, 2 + (3 * i)]);
		total += "\n";
		for (int i = 0; i < 3; i++) 
			total += System.String.Format("\t{0},{1},{2},\n", cube[5,0+ (3*i)], cube[5,1+ (3*i)], cube[5,2+ (3*i)]);
		
		return total;
	}

	void Start () {

		Debug.Log(printCube ());

		for (int x = 0; x < 3; x++) {
			for (int y = 0; y < 3; y++){
				for (int z = 0; z < 3; z++){
					Instantiate (cubelet, new Vector3 (x, y, z), new Quaternion (0, 0, 0, 0));
				}
			}
		}
	}



	/*

		Map:

			B
		W	R	Y	O
			G
			
			U
		L	F	R	B
			D

			0
		1	2	3	4
			5


		Specifically

		Corners:		Should have 4*2 = 	8
		Edges: 			Should have 4*3 = 	12
		Centers:		Should have 		6



		More Detailed Map:
		
    				  0	0,1,2,
	    				3,4,5,
		    		 	6,7,8,

		  1	0,1,2,	  2	0,1,2,	  3	0,1,2,	  4	0,1,2
			3,4,5,		3,4,5,		3,4,5,		3,4,5
			6,7,8,		6,7,8,		6,7,8,		6,7,8

					  5	0,1,2,
						3,4,5,
						6,7,8,
		Going to use as a Template for the Cube Print Out

		Corners:
		Cube[0][0]	Cube[1][0]	Cube[4][2]
		Cube[0][2]	Cube[3][2]	Cube[4][0]	
		Cube[0][6]	Cube[1][2]	Cube[2][0]	
		Cube[0][8]	Cube[2][2]	Cube[3][0]	
		Cube[1][6]	Cube[4][8]	Cube[5][6]
		Cube[1][8]	Cube[2][6]	Cube[5][0]	
		Cube[2][8]	Cube[3][6]	Cube[5][2]
		Cube[3][8]	Cube[4][6]	Cube[5][8]

		Edges:	Might want to sort these later
			Cube[0][1]	Cube[4][1] (Not Sure)
			Cube[0][3]	Cube[1][1]
			Cube[0][5]	Cube[3][1]
			Cube[0][7]	Cube[2][1]
			Cube[1][3]	Cube[4][5]
			Cube[1][5]	Cube[2][3]
			Cube[1][7]	Cube[5][3]
			Cube[3][3]	Cube[2][5]
			Cube[3][5]	Cube[4][3]	
			Cube[3][7]	Cube[5][5]
			Cube[4][7]	Cube[5][7]  (Not Sure)
			Cube[5][1]	Cube[2][7]  

		Centers:
			cube[0][4]
			cube[1][4]
			cube[2][4]
			cube[3][4]
			cube[4][4]
			cube[5][4]

		Observatios:
		4's are center points

		Odd Numbers are Edges

		Even Numbers are Corners
		
	*/

}
