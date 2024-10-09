using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float shootInterval = 5f;
    private float intervalBullet = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intervalBullet += Time.deltaTime;

        if(intervalBullet >= shootInterval)
        {
            shoot();
            intervalBullet = 0f;
        }
    }

    void shoot()
    {
        GameObject blt = Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
