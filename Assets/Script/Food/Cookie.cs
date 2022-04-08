using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : Food
{
    int speed = 4;
    int hitPoints = 8;

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
