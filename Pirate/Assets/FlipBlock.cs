using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBlock : MonoBehaviour
{
    private Transform player;
    public float x=0;
    public float y = 0;
    void Start()
    {
        player = GameObject.Find("Protagonista").transform;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + x, player.position.y + y, 0);
    }
}

