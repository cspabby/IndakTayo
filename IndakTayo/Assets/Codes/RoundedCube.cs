using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class RoundedCube : MonoBehaviour
{
    public float radius = 0.2f; // The amount to "round" the edges of the cube
    private Mesh mesh;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            // Apply a rounding effect to each vertex
            vertices[i] = vertices[i].normalized * (1.0f - radius) + vertices[i] * radius;
        }

        // Update the mesh with the modified vertices
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
    }
}
