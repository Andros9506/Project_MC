using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Take : MonoBehaviour
{
    public Transform collideTakePoint;
    public float takeRange = 0.5f;
    private Rigidbody2D _rigidBody;
    //private BoxCollider2D boxCollider2D;
    private CircleCollider2D circleCollider2D;
    public LayerMask layerMask;

    private void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
        // boxCollider2D = transform.GetComponent<BoxCollider2D>();
        // circleCollider2D = transform.GetComponent<CircleCollider2D>();
        //Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(collideTakePoint.position, takeRange, layerMask);
        //Physics2D.Raycast(circleCollider2D.bounds.center, Vector2.zero, layerMask);
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.right, layerMask);
        Debug.Log("tag: " + raycastHit2D.collider.tag);
        Debug.DrawRay(transform.position, Vector2.right);
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.tag);
        if (collision.tag == "Player") {
           HealthBar.health +=1;
            Destroy(this.gameObject);
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Color rayColor;
        
       // Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(collideTakePoint.position, takeRange, layerMask);
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.right, layerMask);
        Debug.Log("tag: " + raycastHit2D.collider.tag);
        Debug.DrawRay(transform.position, Vector2.right);
    }*/
    public void Heal()
    {
       HealthBar.health +=1;
    }

  /*  private void OnDrawGizmosSelected()
    {
        // Gizmos.DrawWireSphere(collideTakePoint.position, takeRange);
       
    }*/
}
