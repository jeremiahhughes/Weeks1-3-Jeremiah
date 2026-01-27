using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.LightTransport;

public class MusicNote : MonoBehaviour
{
    // Variables
    public float speed = 5;
    public AnimationCurve shrinkCurve;
    public float t = 0;
    Vector3 mousePos;
    public static bool isHovering;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the notes to the right on the x-axis with Time.deltaTime
        transform.position += new Vector3(1,0,0) * speed * Time.deltaTime;
        // Going from World to ScreenPoint and getting transform.position
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {
           speed = speed * -1;
        }
        
        mousePos = Input.mousePosition; // https://www.youtube.com/watch?v=EWxxFmiWlbc&t=111s citing the line of code i used from this video at timestamp 2:46

        // Showing how close the cursor is to the center of the note
        float distance = Vector2.Distance(mousePos, screenPos);

        if (distance < 100)
        {
            isHovering = true; // Tells the face sprite its hovering over a note
            if (t < 1)
            {
                t += Time.deltaTime * 2; // Shrinks the music note sprite when the mouse cursor is on 
            }
        }
        else
        {
            isHovering = false; // Tells the face sprite the mouse cursor is away from it
            if (t > 0)
            {
                t -= Time.deltaTime * 2; // Goes back to its normal size when the mouse cursor is off
            }
        }

        float scaleValue = shrinkCurve.Evaluate(t);
        // Using a new Vector2 to set the Scale of the Sprites when you press play
        transform.localScale = new Vector2(0.6f,0.6f) * scaleValue;
    }
}
