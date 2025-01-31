using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{

    Vector2 mousePos;
    public AnimationCurve breathe;
    public SpriteRenderer spriteRend;
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
        t += Time.deltaTime * 0.3f;

        if (t > 1)
        {
            t = 0;
        }

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (spriteRend.bounds.Contains(mousePos))
        {
            transform.localScale = baseSize * 3.5f;
        }
        else
        {
            transform.localScale = Vector2.Lerp(baseSize, baseSize + new Vector2(0.1f,0.1f),breathe.Evaluate(t));
        }

    }
}
