using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
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
        this.transform.position += Vector3.forward * Time.deltaTime * speed;
    }

    public void OnCustomCollisionEnter(Collision collision, int hitFoodPoints)
    {
        
        if (collision.gameObject.CompareTag("Animal"))
        {
            GameObject animalGO = collision.gameObject;
            GameObject gameManagerGO =  GameObject.FindGameObjectWithTag("Game Manager");
            GameManager gameManager = gameManagerGO.GetComponent<GameManager>();
            Animal animal = animalGO.GetComponent<Animal>();
            gameManager.animalHit(animal.HitPoints(), hitFoodPoints);
            Destroy(gameObject);
        }
    }


}
