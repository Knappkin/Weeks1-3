using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShapeSpawner : MonoBehaviour
{
    public Vector2 mousePos;
    public GameObject prefab;
    public ColourHover square;
    public List<ColourHover> squares = new List<ColourHover>();
    public bool hovering;
    // Start is called before the first frame update
    void Start()
    {
        hovering = false; 
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
          for(int i=0; i < squares.Count; i++)
            {
                if (square.spriteRenderer.bounds.Contains(mousePos))
                {
                    hovering = true;
                }
               if (hovering == false)
                {
                    createSquare();
                }
            }
     
        }

    }

    void createSquare()
    {
        GameObject spawnSquare = Instantiate(prefab);
        square = spawnSquare.GetComponent<ColourHover>();
        squares.Add(square);
    }

}
