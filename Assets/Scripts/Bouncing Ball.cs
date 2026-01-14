using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float speed = 0.01f;
    public float speed2 = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        newPosition.y += speed2;
        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.x < -9 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
       else if(screenPos.y < -4.5 || screenPos.y > Screen.height)
       {
         speed2 = speed2 * -1;
       }
    }
}



