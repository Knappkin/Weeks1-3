using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{

    Vector2 mousePos;
    public AnimationCurve breathe;
    //included spriterenderer so I could check if mouse was within bounds of the mouth
    public SpriteRenderer spriteRend;

    //variable for the base size of the mouth so it can go back to it after the mouth grows
    public Vector2 baseSize = new Vector2(0.15f,0.15f);
    float t;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = baseSize;
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // *0.3 to slow the movement
        t += Time.deltaTime * 0.3f;

        if (t > 1)
        {
            t = 0;
        }

        //Getting mouse position on screen
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Checks if the mouse is hovering over the mouth
        if (spriteRend.bounds.Contains(mousePos))
        {
           //Mouth "opens" when hovered over
            transform.localScale = baseSize * 3.5f;
        }
        else
        {
            //Setting back to the normal size + adding snoring effect
            transform.localScale = Vector2.Lerp(baseSize, baseSize + new Vector2(0.1f,0.1f),breathe.Evaluate(t));
        }

    }
}
