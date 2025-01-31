using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepZs : MonoBehaviour
{

    //Two separate animation curves for the x and y movement
    public AnimationCurve horiZ;
    public AnimationCurve vertZ;

    //made t public so I could set different starting values for each Z object
    public float t;

    //I was testing the values for the lerp bounds, so I added them as a public variable for testing with the inspector

    //horizontal bounds
    public float startH;
    public float endH;

    //vertical bounds
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
        
        //moving the Zs with lerp
        Vector2 pos = transform.position;
        pos.x = Mathf.Lerp(startH,endH, horiZ.Evaluate(t));
        pos.y = Mathf.Lerp(startV,endV, vertZ.Evaluate(t));

        transform.position = pos;

    }
}
