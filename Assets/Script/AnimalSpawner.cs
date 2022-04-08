using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] animal;
    [SerializeField] float delay = 1;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            int randomAnimal = Random.Range(0, animal.Length);
            Instantiate(animal[randomAnimal]);
            timer = 0;
        }
    }
}
