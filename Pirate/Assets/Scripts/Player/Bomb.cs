using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float speed = 4;
    public Vector3 LaunchOffSet;
    public bool Thrown;


    // Start is called before the first frame update
    void Start()
    {
        if (Thrown)
        {
            var direction = transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
        }
        transform.Translate(LaunchOffSet);

       // Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Thrown)
        {
            transform.position += -transform.up * speed * Time.deltaTime;
        }
    }
}
