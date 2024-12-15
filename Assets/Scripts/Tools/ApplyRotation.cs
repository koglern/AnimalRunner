using UnityEngine;

using UnityEngine;
using UnityEditor;

public class ApplyRotation : MonoBehaviour
{
    [MenuItem("Tools/Apply Rotation")]
    static void ApplyTransformRotation()
    {
        GameObject obj = Selection.activeGameObject;

        if (obj == null)
        {
            Debug.LogWarning("No GameObject selected.");
            return;
        }

        // Store current rotation
        Quaternion currentRotation = obj.transform.rotation;

        // Reset rotation
        obj.transform.rotation = Quaternion.identity;

        // Apply rotation to mesh vertices (optional, for mesh alignment)
        MeshFilter meshFilter = obj.GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            Mesh mesh = meshFilter.mesh;
            Vector3[] vertices = mesh.vertices;

            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = currentRotation * vertices[i];
            }

            mesh.vertices = vertices;
            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
        }

        Debug.Log("Rotation applied and reset!");
    }
}

