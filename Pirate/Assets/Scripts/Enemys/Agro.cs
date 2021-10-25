using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agro : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float AgroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
       // print("distanceToPlayer: " + distanceToPlayer);

        if (distanceToPlayer < AgroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }
    }

    void ChasePlayer()
    {
        gameObject.GetComponent<Patrol>().enabled = false;
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        if (transform.position.x < player.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (transform.position.x > player.position.x)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }
    void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0, 0);
        gameObject.GetComponent<Patrol>().enabled = true;
    }
}
