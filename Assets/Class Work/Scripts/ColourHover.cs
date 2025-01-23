using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourHover : MonoBehaviour
{
    public Vector2 mousePos;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }

    // Update is called once per frame
    void Update()
    {


        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // if (mousePos.x > transform.position.x - transform.localScale.x/2 && mousePos.x < transform.position.x + transform.localScale.x / 2 && mousePos.y > transform.position.y - transform.localScale.y/2 && mousePos.y < transform.position.y + transform.localScale.y/2)
       
        if (spriteRenderer.bounds.Contains(mousePos))
      
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }
}
