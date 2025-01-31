using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{

    Vector2 mousePos;
    public AnimationCurve breathe;
    public SpriteRenderer spriteRend;
    public Vector2 baseSize = new Vector2(0.15f,0.15f);

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = baseSize;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (spriteRend.bounds.Contains(mousePos))
        {
            transform.localScale = baseSize * 4;
        }
        else
        {
            transform.localScale = baseSize;
        }
    }
}
