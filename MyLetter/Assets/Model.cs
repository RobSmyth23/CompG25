using UnityEngine;
using System.Collections.Generic;
public class Model 
{
    List<Vector3> vertices = new List<Vector3>();
    List<Vector3Int> faces = new List<Vector3Int>();

    public Model()
    {
        defineVertices();
        defineFaces();
        CreateUnityGameObject();
    }

    private void defineFaces()
    {
        //good practice 1 face at a time check back and forth etc.
        //faces front of letter
        faces = new List<Vector3Int>();
        faces.Add(new Vector3Int(0, 1, 7)); //Face 1
        faces.Add(new Vector3Int(0, 7, 10)); //Face 2
        faces.Add(new Vector3Int(0, 10, 13)); //Face 3
        faces.Add(new Vector3Int(10, 7, 8)); //Face 4
        faces.Add(new Vector3Int(0, 13, 16)); //Face 5
        faces.Add(new Vector3Int(16, 13, 14)); //Face 6
        faces.Add(new Vector3Int(16, 14, 15)); //Face 7
        faces.Add(new Vector3Int(14, 12, 15)); //Face 8
        faces.Add(new Vector3Int(14, 11, 12)); //Face 9
        faces.Add(new Vector3Int(11, 9, 12)); //Face 10
        faces.Add(new Vector3Int(11, 8, 9)); //Face 11
        faces.Add(new Vector3Int(10, 8, 11)); //Face 12
        faces.Add(new Vector3Int(8, 7, 5)); //Face 13
        faces.Add(new Vector3Int(8, 5, 6)); //Face 14
        faces.Add(new Vector3Int(5, 3, 6)); //Face 15
        faces.Add(new Vector3Int(6, 3, 4)); //Face 16
        faces.Add(new Vector3Int(7, 1, 2)); //Face 17
        //
        // //faces back of letter
        // faces.Add(new Vector3Int()); //Face 18
        // faces.Add(new Vector3Int()); //Face 19
        // faces.Add(new Vector3Int()); //Face 20
        // faces.Add(new Vector3Int()); //Face 21
        // faces.Add(new Vector3Int()); //Face 22
        // faces.Add(new Vector3Int()); //Face 23
        // faces.Add(new Vector3Int()); //Face 24
        // faces.Add(new Vector3Int()); //Face 25
        // faces.Add(new Vector3Int()); //Face 26
        // faces.Add(new Vector3Int()); //Face 27
        // faces.Add(new Vector3Int()); //Face 28
        // faces.Add(new Vector3Int()); //Face 29
        // faces.Add(new Vector3Int()); //Face 30
        // faces.Add(new Vector3Int()); //Face 31
        // faces.Add(new Vector3Int()); //Face 32
        // faces.Add(new Vector3Int()); //Face 33
        // //faces on sides of letter and inside
        
    }

    private void defineVertices()
    {
        //front of letter z=1
        vertices = new List<Vector3>();
        vertices.Add(new Vector3(-2, 6, 1)); //v 0
        vertices.Add(new Vector3(-2, -6, 1)); //v 1
        vertices.Add(new Vector3(-1, -6, 1)); //v 2
        vertices.Add(new Vector3(1, -6, 1)); //v 3
        vertices.Add(new Vector3(2, -6, 1)); //v 4
        vertices.Add(new Vector3(1, -5, 1)); //v 5
        vertices.Add(new Vector3(2, -5, 1)); //v 6
        vertices.Add(new Vector3(-1, -1, 1)); //v 7
        vertices.Add(new Vector3(-1, 0, 1)); //v 8
        vertices.Add(new Vector3(2, 0, 1)); //v 9
        vertices.Add(new Vector3(-1, 1, 1)); //v 10
        vertices.Add(new Vector3(1, 1, 1)); //v 11
        vertices.Add(new Vector3(2, 1, 1)); //v 12
        vertices.Add(new Vector3(-1, 5, 1)); //v 13
        vertices.Add(new Vector3(1, 5, 1)); //v 14
        vertices.Add(new Vector3(2, 5, 1)); //v 15
        vertices.Add(new Vector3(1, 6, 1)); //v 16
        //back of letter z=-1
        vertices.Add(new Vector3(-2, 6, -1)); //v 0
        vertices.Add(new Vector3(-2, -6, -1)); //v 1
        vertices.Add(new Vector3(-1, -6, -1)); //v 2
        vertices.Add(new Vector3(1, -6, -1)); //v 3
        vertices.Add(new Vector3(2, -6, -1)); //v 4
        vertices.Add(new Vector3(1, -5, -1)); //v 5
        vertices.Add(new Vector3(2, -5, -1)); //v 6
        vertices.Add(new Vector3(-1, -1, -1)); //v 7
        vertices.Add(new Vector3(-1, 0, -1)); //v 8
        vertices.Add(new Vector3(2, 0, -1)); //v 9
        vertices.Add(new Vector3(-1, 1, -1)); //v 10
        vertices.Add(new Vector3(1, 1, -1)); //v 11
        vertices.Add(new Vector3(2, 1, -1)); //v 12
        vertices.Add(new Vector3(-1, 5, -1)); //v 13
        vertices.Add(new Vector3(1, 5, -1)); //v 14
        vertices.Add(new Vector3(2, 5, -1)); //v 15
        vertices.Add(new Vector3(1, 6, -1)); //v 16
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
