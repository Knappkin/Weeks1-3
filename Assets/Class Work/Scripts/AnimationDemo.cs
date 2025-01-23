using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationDemo : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0,1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }
        transform.localScale = Vector2.one * curve.Evaluate(t);

    }
}
