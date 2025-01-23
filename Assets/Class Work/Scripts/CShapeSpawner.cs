using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShapeSpawner : MonoBehaviour
{
    public Vector2 mousePos;
    public GameObject prefab;
    public ColourHover square;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
          
                createSquare();
        }

    }

    void createSquare()
    {
        GameObject spawnSquare = Instantiate(prefab);
        square = spawnSquare.GetComponent<ColourHover>();
    }

    void destroySquare()
    {
        Destroy(square);
    }
}
