using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mower : MonoBehaviour
{

    public GameObject painter;
    public float cutRadius = 0.9f;
    public float remainLength = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        painter.GetComponent<GeometryGrassPainter>().CutHere(
            this.transform.position, 
            cutRadius, 
            remainLength);
    }
}
