using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Animal
{
    int speed = 16;
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

    public override int HitPoints()
    {
        return hitPoints;
    }
}
