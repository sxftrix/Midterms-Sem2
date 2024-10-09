using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float detector = 10f;
    public Color gizmocol = Color.red;

    private Transform clostestEneneamy;

    void clostestEnemy()
    {
        GameObject[] redEnemy = GameObject.FindGameObjectsWithTag("redEnemy");
        GameObject[] blueEnemy = GameObject.FindGameObjectsWithTag("blueEnemy");
        GameObject[] greenEnemy = GameObject.FindGameObjectsWithTag("greenEnemy");

        Transform playerTransform = transform;

        float nearestDistance = detector;

        //rangeChecker(redEnemy, playerTransform, ref nearestDistance);
        //rangeChecker(blueEnemy, playerTransform, ref nearestDistance);
        //rangeChecker(greenEnemy, playerTransform, ref nearestDistance);

    }

    //void rangeChecker(GameObject[], Enemy, Transform playerTransform, ref float rangeChecker) 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
