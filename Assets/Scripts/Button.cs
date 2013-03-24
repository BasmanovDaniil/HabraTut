using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject door;

    private int colliderCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (colliderCount == 0)
        {
            door.SetActive(false);
            transform.localPosition += new Vector3(0, 0, 0.3f);
            renderer.material.color = new Color(1, 0, 0);
        }
        colliderCount++;
    }

    void OnTriggerExit(Collider other)
    {
        colliderCount--;
        if (colliderCount == 0)
        {
            door.SetActive(true);
            transform.localPosition -= new Vector3(0, 0, 0.3f);
            renderer.material.color = new Color(0, 1, 0);
        }
    }
}
