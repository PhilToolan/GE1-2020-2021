using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public int elements = 12;
    public int radius = 1;
    public int rings = 10;
    public GameObject shape;

    

    // Start is called before the first frame update
    void Start()
    {

        for(int j = 0 ; j < rings ; j++)
        {
            elements = (int)(2.0f * Mathf.PI * j * radius);
            float theta = Mathf.PI * 2.0f / (float) elements;

            for(int i = 0 ; i < elements ; i ++)
            {
                GameObject s = GameObject.Instantiate<GameObject>(shape);
                Vector3 pos = new Vector3((Mathf.Sin(theta * i) * radius * j * 1.2f), (Mathf.Cos(theta * i) * radius * j * 1.2f), 0);
                s.transform.position = transform.TransformPoint(pos);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
