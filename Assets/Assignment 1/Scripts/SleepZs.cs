using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepZs : MonoBehaviour
{

    public AnimationCurve horiZ;
    public AnimationCurve vertZ;
    public float t;
    public float startH;
    public float endH;
    public float startV;
    public float endV;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * 0.5f;

        if (t > 1)
        {
            t = 0;
        }
        
        Vector2 pos = transform.position;
        pos.x = Mathf.Lerp(startH,endH, horiZ.Evaluate(t));
        pos.y = Mathf.Lerp(startV,endV, vertZ.Evaluate(t));

        transform.position = pos;

    }
}
