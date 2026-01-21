using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    //PickARandomColor();
        //}

        //get mouse position 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // is it over the sprite
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //y use the col variable 
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColor() 
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
