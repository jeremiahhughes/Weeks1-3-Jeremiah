using UnityEngine;

public class RotatemeClock : MonoBehaviour
{
    public float speed = -100;
    public float speed2 = -1200;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
        Vector3 newRotation2 = transform.eulerAngles;
        newRotation2.z += speed2 * Time.deltaTime;
        transform.eulerAngles = newRotation2;
    }
}
