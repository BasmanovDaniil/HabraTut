using UnityEngine;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            if (Application.loadedLevel + 1 != Application.levelCount)
                Application.LoadLevel(Application.loadedLevel + 1);
            else
                Application.LoadLevel(0);
    }
}