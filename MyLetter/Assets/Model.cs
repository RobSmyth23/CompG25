using UnityEngine;
using System.Collections.Generic;

public class Model
{
	List<Vector3> vertices;
	List<Vector3Int> faces;

	public Model()
	{
		defineVertices();
		defineFaces();
		CreateUnityGameObject();
	}

	void defineVertices()
	{
		//front vertices
	vertices = new List<Vector3>();
	vertices.Add(new Vector3(-3f, 8f, 1f) ); //0
	vertices.Add(new Vector3(-3f,-9f, 1f) ); //1
	vertices.Add(new Vector3(-1f,-9f, 1f) ); //2
	vertices.Add(new Vector3(2f,-9f, 1f) ); //3
	vertices.Add(new Vector3(4f,-9f, 1f) ); //4
	vertices.Add(new Vector3(2f,-6f, 1f) ); //5
	vertices.Add(new Vector3(4f,-5f, 1f) ); //6
	vertices.Add(new Vector3(-1f,-3f, 1f) ); //7
	vertices.Add(new Vector3(-1f, 0f, 1f) ); //8
	vertices.Add(new Vector3(3f,0f, 1f) ); //9
	vertices.Add(new Vector3(4f,1f, 1f) ); //10
	vertices.Add(new Vector3(-2f,2f, 1f) ); //11
	vertices.Add(new Vector3(3f,2f, 1f) ); //12
	vertices.Add(new Vector3(-2f,7f, 1f) ); //13
	vertices.Add(new Vector3(3f,7f, 1f) ); //14
	vertices.Add(new Vector3(4f,8f, 1f) ); //15
	vertices.Add(new Vector3(3f,8f, 1f) ); //16
	
		//back vertices
	vertices.Add(new Vector3(-3f, 8f, -1f) ); //17
	vertices.Add(new Vector3(-3f,-9f, -1f) ); //18
	vertices.Add(new Vector3(-1f,-9f, -1f) ); //19
	vertices.Add(new Vector3(2f,-9f, -1f) ); //20
	vertices.Add(new Vector3(4f,-9f, -1f) ); //21
	vertices.Add(new Vector3(2f,-6f, -1f) ); //22
	vertices.Add(new Vector3(4f,-5f, -1f) ); //23
	vertices.Add(new Vector3(-1f,-3f, -1f) ); //24
	vertices.Add(new Vector3(-1f, 0f, -1f) ); //25
	vertices.Add(new Vector3(3f,0f, -1f) ); //26
	vertices.Add(new Vector3(4f,1f, -1f) ); //27
	vertices.Add(new Vector3(-2f,2f, -1f) ); //28
	vertices.Add(new Vector3(3f,2f, -1f) ); //29
	vertices.Add(new Vector3(-2f,7f, -1f) ); //30
	vertices.Add(new Vector3(3f,7f, -1f) ); //31
	vertices.Add(new Vector3(4f,8f, -1f) ); //32
	vertices.Add(new Vector3(3f,8f, -1f) ); //33


	}

	void defineFaces()
	{
		//front faces
	faces = new List<Vector3Int>();
	faces.Add(new Vector3Int(0, 1, 13) ); //Face 0
	faces.Add(new Vector3Int(13, 1 ,10) ); //Face 1
	faces.Add(new Vector3Int(7, 1, 2) ); //Face 2
	faces.Add(new Vector3Int(10, 7, 8) ); //Face 3
	faces.Add(new Vector3Int(0, 13, 14) ); //Face 4
	faces.Add(new Vector3Int(0, 14, 16) ); //Face 5
	faces.Add(new Vector3Int(16, 14, 15) ); //Face 6
	faces.Add(new Vector3Int(14, 11, 15) ); //Face 7
	faces.Add(new Vector3Int(15, 11, 12) ); //Face 8
	faces.Add(new Vector3Int(11, 9, 12) ); //Face 9 
	faces.Add(new Vector3Int(11, 8, 9) ); //Face 10
	faces.Add(new Vector3Int(11, 10, 8) ); //Face 11
	faces.Add(new Vector3Int(7, 5, 8) ); //Face 12
	faces.Add(new Vector3Int(8, 5, 6) ); //Face 13
	faces.Add(new Vector3Int(6, 5, 3) ); //Face 14
	faces.Add(new Vector3Int(6, 3, 4) ); //Face 15
	
		//back faces
	faces.Add(new Vector3Int(17, 18, 30) ); //Face 17
	faces.Add(new Vector3Int(30, 18, 27) ); //Face 18
	faces.Add(new Vector3Int(24, 18, 19) ); //Face 19
	faces.Add(new Vector3Int(27, 24, 25) ); //Face 20
	faces.Add(new Vector3Int(17, 30, 31) ); //Face 21
	faces.Add(new Vector3Int(17, 31, 33) ); //Face 22
	faces.Add(new Vector3Int(33, 31, 32) ); //Face 23
	faces.Add(new Vector3Int(31, 28, 29) ); //Face 24
	faces.Add(new Vector3Int(32, 31, 29) ); //Face 25
	faces.Add(new Vector3Int(28, 26, 29) ); //Face 26 
	faces.Add(new Vector3Int(28, 27, 26) ); //Face 27
	faces.Add(new Vector3Int(27, 25, 26) ); //Face 28
	faces.Add(new Vector3Int(24, 22, 25) ); //Face 29
	faces.Add(new Vector3Int(25, 22, 23) ); //Face 30
	faces.Add(new Vector3Int(23, 22, 21) ); //Face 31
	faces.Add(new Vector3Int(22, 20, 21) ); //Face 32
	
		//side faces
	faces.Add(new Vector3Int(0, 18, 17) ); //face 34
	faces.Add(new Vector3Int(1, 18, 0) ); // face 35
	faces.Add(new Vector3Int(33, 0, 17) ); // face 36
	faces.Add(new Vector3Int(33, 16, 0) ); // face 37

	
	}

	public GameObject CreateUnityGameObject()
	{
		Mesh mesh = new Mesh();
		GameObject newGO = new GameObject();
     
		MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
		MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

		List<Vector3> coords = new List<Vector3>();
		List<int> dummy_indices = new List<int>();
		/*List<Vector2> text_coords = new List<Vector2>();
		List<Vector3> normalz = new List<Vector3>();*/

		for (int i = 0; i < faces.Count; i++)
		{
			//Vector3 normal_for_face = normals[i];

			//normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

			coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

			coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

			coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
		}

		mesh.vertices = coords.ToArray();
		mesh.triangles = dummy_indices.ToArray();
		/*mesh.uv = text_coords.ToArray();
		mesh.normals = normalz.ToArray();*/
		mesh_filter.mesh = mesh;

		return newGO;
	}
}
