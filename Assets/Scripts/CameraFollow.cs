using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = new Vector3(target.position.x, transform.position.y, transform.position.z);

        // You may lerp to reduce dizziness of fast moving objects.
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 10);
    }
}
