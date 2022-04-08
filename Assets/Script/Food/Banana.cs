using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Food
{
    int speed = 2;
    int hitPoints = 16;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Move(speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        base.OnCustomCollisionEnter(collision, hitPoints);
    }
}
