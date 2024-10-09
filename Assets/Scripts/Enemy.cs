using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 10f;
    public string enemyColor;

    private Transform playerPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemyColor + "Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerPos == null)
        {
            Debug.LogError("Nuh uh none to hit homie");
            enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if ( playerPos != null )
        {
            Vector3 moveDirection = (playerPos.position - transform.position).normalized;
            transform.Translate(moveDirection * movementSpeed * Time.deltaTime);
        }
    }
}
