using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.tag);
        if (collision.tag == "Player")
        {
            HealthBar.health += 1;
            Destroy(this.gameObject);
        }
    }
}
