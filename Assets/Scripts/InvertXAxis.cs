using UnityEngine;
using UnityEngine.UI;

public class InvertXAxis : MonoBehaviour
{
    void Start()
    {
        // Find all objects in the scene
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        // Iterate through each object and invert its X-axis position
        foreach (GameObject obj in allObjects)
        {
             if (!obj.GetComponent<Graphic>())
            {
                Vector3 position = obj.transform.position;
                position.x = -position.x;
                obj.transform.position = position;
            }
        }
    }
}
