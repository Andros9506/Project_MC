using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Take : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        
    }
    
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision " + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Heal();
            Destroy(this.gameObject);
        }
    }

    void Heal()
    {
        player.GetComponent<Player_Stats>().Heal(20);
    }*/
}
