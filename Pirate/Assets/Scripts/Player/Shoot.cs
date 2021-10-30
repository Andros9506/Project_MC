using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Bomb bomb;
    public Transform LaunchOffSet;
    public Player_Movements pm;
    int numBomb;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.FindGameObjectsWithTag("Bomb").Length < 3)
        {
            Instantiate(bomb, LaunchOffSet.position, pm.transform.rotation);
        }
    }

   

}
