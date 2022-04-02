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

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Animal"))
        {
            GameObject animal = collision.gameObject;
            GameObject gameManagerGO =  GameObject.FindGameObjectWithTag("Game Manager");
            GameManager gameManager = gameManagerGO.GetComponent<GameManager>();
            gameManager.animalHit(animal);
            Destroy(gameObject);
        }
    }


}
