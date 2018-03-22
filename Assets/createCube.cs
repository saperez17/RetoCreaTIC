using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof (MeshFilter))]
//[RequireComponent(typeof (MeshRenderer))]

public class createCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		CreateCube ();
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector2[] UVs = new Vector2[mesh.vertices.Length];


		// Front
		UVs[0] = new Vector2(0.0f, 0.0f);
		UVs[1] = new Vector2(0.333f, 0.0f);
		UVs[2] = new Vector2(0.0f, 0.333f);
		UVs[3] = new Vector2(0.333f, 0.333f);
		// Top
		UVs[4] = new Vector2(0.334f, 0.333f);
		UVs[5] = new Vector2(0.666f, 0.333f);
		UVs[8] = new Vector2(0.334f, 0.0f);
		UVs[9] = new Vector2(0.666f, 0.0f);
		// Back
		UVs[6] = new Vector2(1.0f, 0.0f);
		UVs[7] = new Vector2(0.667f, 0.0f);
		UVs[10] = new Vector2(1.0f, 0.333f);
		UVs[11] = new Vector2(0.667f, 0.333f);
		// Bottom
		UVs[12] = new Vector2(0.0f, 0.334f);
		UVs[13] = new Vector2(0.0f, 0.666f);
		UVs[14] = new Vector2(0.333f, 0.666f);
		UVs[15] = new Vector2(0.333f, 0.334f);
		// Left
		UVs[16] = new Vector2(0.334f, 0.334f);
		UVs[17] = new Vector2(0.334f, 0.666f);
		UVs[18] = new Vector2(0.666f, 0.666f);
		UVs[19] = new Vector2(0.666f, 0.334f);
		// Right        
		UVs[20] = new Vector2(0.667f, 0.334f);
		UVs[21] = new Vector2(0.667f, 0.666f);
		UVs[22] = new Vector2(1.0f, 0.666f);
		UVs[23] = new Vector2(1.0f, 0.334f);
		mesh.uv = UVs;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	private void CreateCube(){
//		float size = 1f;
//		Vector3[] vertices = {
////			new Vector3 (0, 0, 0),
////			new Vector3 (1, 0, 0),
////			new Vector3 (1, 1, 0),
////			new Vector3 (0, 1, 0),
////			new Vector3 (0, 1, 1),
////			new Vector3 (1, 1, 1),
////			new Vector3 (1, 0, 1),
////			new Vector3 (0, 0, 1),
//
//			new Vector3(0, size, 0),
//			new Vector3(0, 0, 0),
//			new Vector3(size, size, 0),
//			new Vector3(size, 0, 0),
//
//			new Vector3(0, 0, size),
//			new Vector3(size, 0, size),
//			new Vector3(0, size, size),
//			new Vector3(size, size, size),
//
//			new Vector3(0, size, 0),
//			new Vector3(size, size, 0),
//
//			new Vector3(0, size, 0),
//			new Vector3(0, size, size),
//
//			new Vector3(size, size, 0),
//			new Vector3(size, size, size),
//
//		};
//
//		int[] triangles = {
//			0, 2, 1,	 // face front
//			0, 3, 2,
//
//			2, 3, 4,	//face top
//			2, 4, 5,
//
//			1, 2, 5,	//face right
//			1, 5, 6,
//
//			0, 7, 4,	//face left
//			0, 4, 3,
//
//			5, 4, 7,	//face back
//			5, 7, 6,
//
//			0, 6, 7,	//face bottom
//			0, 1, 6,
//		};
//
//		Vector2[] uvs = {
//			new Vector2(0, 0.66f),
//			new Vector2(0.25f, 0.66f),
//			new Vector2(0, 0.33f),
//			new Vector2(0.25f, 0.33f),
//
//			new Vector2(0.5f, 0.66f),
//			new Vector2(0.5f, 0.33f),
//			new Vector2(0.75f, 0.66f),
//			new Vector2(0.75f, 0.33f),
//
//			new Vector2(1, 0.66f),
//			new Vector2(1, 0.33f),
//
//			new Vector2(0.25f, 1),
//			new Vector2(0.5f, 1),
//
//			new Vector2(0.25f, 0),
//			new Vector2(0.5f, 0),
//		};	
//
//		Mesh mesh = GetComponent<MeshFilter> ().mesh;
//		mesh.Clear ();
//		mesh.vertices = vertices;
//		mesh.triangles = triangles;
//		//mesh.Optimize ();
//		mesh.uv = uvs;
//		mesh.RecalculateNormals ();
//	}
}
