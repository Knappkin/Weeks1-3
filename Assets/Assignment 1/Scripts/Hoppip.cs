using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoppip : MonoBehaviour
{
    public AnimationCurve floaty;
    [Range(0f, 1f)]
    public float t;
    float speed;
    Vector2 pos;
    Vector2 rightEdge;
    Vector2 leftEdge;
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
        t += Time.deltaTime *0.8f;

        if (t > 1)
       {
           t = 0;
        }

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        pos = transform.position;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x + offsetAmount < 0)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)).x;
           
        }

        if (screenPos.x - offsetAmount > Screen.width)
        {
            pos.x = Camera.main.ScreenToWorldPoint(Vector2.zero).x;
        }

     
        pos.y = Mathf.Lerp(2, 4, floaty.Evaluate(t));
        transform.position = pos;


    }
}
