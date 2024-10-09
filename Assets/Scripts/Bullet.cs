using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 5f;
    public string bulletColor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("redEnemy") ||
            other.gameObject.CompareTag("blueEnemy") ||
            other.gameObject.CompareTag("greenEnemy"))
        {
            string enemyColor = other.gameObject.tag.Replace("Enemy", "");

            if(bulletColor == enemyColor)
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
