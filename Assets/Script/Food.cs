using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Move();
    }

    private void Move()
    {
        this.transform.position += Vector3.forward * Time.deltaTime * speed;
    }

    

    
}
