using UnityEngine;

public class FaceReaction : MonoBehaviour
{
    // Variables to change Scale of my face game object
    Vector3 normalScale = new Vector2(0.5f, 0.5f);
    Vector3 biggerScale = new Vector2(0.7f, 0.7f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (MusicNote.isHovering)
        {
            // Using Transform.localScale and Vector 3.Lerp to change the scale to make the face bigger in the bottom
            transform.localScale = Vector3.Lerp(transform.localScale, biggerScale, Time.deltaTime * 10);
        }
        else
        {
            // Using Transform.localScale and Vector 3.Lerp to change the make the face go back to the normal scale in the bottom
            transform.localScale = Vector3.Lerp(transform.localScale, normalScale, Time.deltaTime * 10);
        }

    }
}
