using UnityEngine;

public class Collectible : MonoBehaviour
{
    // On trigger enter
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.name);
    }
}
