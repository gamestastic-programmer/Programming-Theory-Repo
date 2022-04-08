using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    int speed = 4;
    int hitPoints = 4;

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
