using UnityEngine;

public class FaceReaction : MonoBehaviour
{
    // Variables for changing the mouth of the face sprite from normal to happy
    public GameObject normalFace;
    public GameObject happyFace;
    Vector3 normalScale = new Vector2(0.5f, 0.5f);
    Vector3 happyScale = new Vector2(0.7f, 0.7f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (MusicNote.isHovering)
        {
            // Swap to happy face
            normalFace.SetActive(false);
            happyFace.SetActive(true);
            // Using Transform.localScale and Vector 3.Lerp to change the scale of the normal face back to the happy face
            transform.localScale = Vector3.Lerp(transform.localScale, happyScale, Time.deltaTime * 10);
        }
        else
        {
            // Swap to normal face
            normalFace.SetActive(true);
            happyFace.SetActive(false);
            // Using Transform.localScale and Vector 3.Lerp to change the scale of the happy face back to the normal face
            transform.localScale = Vector3.Lerp(transform.localScale, normalScale, Time.deltaTime * 10);
        }

    }
}
