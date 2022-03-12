using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject food;
    float timer = 0;
    float delay = 1;

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
        Debug.Log("Timer: (" + timer + ")");

        if (timer >= delay)
        {
            //Debug.Log ("Moving");
            Instantiate(food);
            timer = 0;
        }
    }

    IEnumerator Shoot()
    {
        Instantiate(food);
        yield return new WaitForSeconds(5);
        
    }
}
