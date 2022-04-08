using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food
{
    int speed = 16;
    int hitPoints = 2;

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
