using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] int speed = 2;
    [SerializeField] GameObject Canvas;
    int hitPoints = 1;

    public int HitPoints { get => hitPoints; set => hitPoints = value; }

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
        this.transform.position += Vector3.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("This animal detected a collision");
    }
}
