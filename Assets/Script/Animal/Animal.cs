using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(int speed)
    {
        this.transform.position += Vector3.right * Time.deltaTime * speed;
    }

    public virtual int HitPoints()
    {
        return 0;
    }
}
