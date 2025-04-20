using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpacer : MonoBehaviour
{
      public List<GameObject> objectsToSpace;  // Assign in Inspector (Obj1 first, then Obj2, etc.)
    public float spacing = 2f;               // Space between each object

    void Start()
    {
        SpaceObjectsBehindFirst();
    }

    void SpaceObjectsBehindFirst()
    {
        if (objectsToSpace.Count == 0) return;

        // Start from the first object's position
        Vector3 startPos = objectsToSpace[0].transform.position;

        for (int i = 0; i < objectsToSpace.Count; i++)
        {
            Vector3 newPos = new Vector3(
                startPos.x - i * spacing, // Go backwards along the X-axis
                startPos.y,
                startPos.z
            );

            objectsToSpace[i].transform.position = newPos;
        }
    }
}
