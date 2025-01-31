using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepZs : MonoBehaviour
{

    public AnimationCurve horiZ;
    public AnimationCurve VertZ;
    public float t;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        
    }
}
