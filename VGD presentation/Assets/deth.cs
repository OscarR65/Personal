using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-17)
        {
            transform.position = new Vector3(-8.9f,1.2f,0);

        }
    }
}
