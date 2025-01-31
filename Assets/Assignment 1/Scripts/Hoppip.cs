using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoppip : MonoBehaviour
{
    public AnimationCurve floaty;

    public float t;
    //speed variable for horizontal movement
    float speed;
    Vector2 pos;
    //added amount when checking if sprite is offscreen so that it won't jump to the other side when the sprite is only halfway across the edge
    public float offsetAmount;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //multiplied by 0.8 to slow the animation
        t += Time.deltaTime *0.8f;

        //loops the animation
        if (t > 1)
       {
           t = 0;
        }

        //Left/Right movement
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        pos = transform.position;

        //Getting the screen position for checking if position is off the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        //Jumping to right side
        if (screenPos.x + offsetAmount < 0)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)).x;
           
        }

        //Jumping to left side
        if (screenPos.x - offsetAmount > Screen.width)
        {
            pos.x = Camera.main.ScreenToWorldPoint(Vector2.zero).x;
        }

        //Added lerp using the animation curve so that hoppip will hover between 2 and 4
        pos.y = Mathf.Lerp(2, 4, floaty.Evaluate(t));
        transform.position = pos;


    }
}
