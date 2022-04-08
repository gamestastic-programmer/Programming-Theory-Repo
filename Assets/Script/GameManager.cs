using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject mainCanvasGO;

    int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animalHit(int animalHitPoints, int foodHitPoints)
    {
        MainCanvas mainCanvas = mainCanvasGO.GetComponent<MainCanvas>();
        score += animalHitPoints * foodHitPoints;
        mainCanvas.UpdateScore(score);
    }
}
