using NUnit.Framework;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
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
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("try to change the sprite");
            //PickARandomColor();
            if (barrels.Count > 0)
            {
                PickARandomColor();
                PickARandomSprite();
            }

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

            if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
            {
                barrels.RemoveAt(0);
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
        randomNumber = Random.Range(0, barrels.Count);

        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }
}