using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels = new Sprite[3];
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();   
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            //PickARandomColor();


            // not this one!!!! spriteRenderer.sprite.bounds.Contains(mousePos) this is at 0, 0 
            // use this one!!!!!! spriteRenderer.bounds.Contains(mousePos) its at the right position

            //get mouse position 
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            // is it over the sprite
            if (spriteRenderer.bounds.Contains(mousePos) == true)
            {
                //y use the col variable 
                spriteRenderer.color = col;
            }
            else
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number between 0 and 2 
        randomNumber = Random.Range(0, barrels.Length);

        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }
}