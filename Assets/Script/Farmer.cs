using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            this.transform.position += Vector3.left;
        if (Input.GetKeyDown(KeyCode.D))
            this.transform.position += Vector3.right;
    }
}
