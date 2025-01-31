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
        pos.y = Mathf.Lerp(1, 3, floaty.Evaluate(t));
        transform.position = pos;


    }
}
