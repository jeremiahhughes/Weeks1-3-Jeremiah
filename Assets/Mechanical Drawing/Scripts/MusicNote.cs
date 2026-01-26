using UnityEngine;

public class MusicNote : MonoBehaviour
{
    public float speed = 5;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moving the notes to the right on the x-axis with Time.deltaTime.
        transform.position += Vector3.right * speed * Time.deltaTime;
        //Going from World to ScreenPoint
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {

           speed = speed * -1;
        }
    }
}
