using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doe : Animal
{
    int speed = 8;
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

    public override int HitPoints()
    {
        return hitPoints;
    }
}
