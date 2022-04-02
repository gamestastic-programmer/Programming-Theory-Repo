using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject food;
    [SerializeField] float delay = 1;
    float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log ("Something is in range");
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            //Debug.Log ("Moving");
            Instantiate(food, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
