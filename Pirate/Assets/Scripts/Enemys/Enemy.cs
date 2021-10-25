using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public Animator animator;
    int currentHealth;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator.SetBool("IsWalk", true);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hit");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Die!!!!!");
        animator.SetBool("IsDead", true);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<Patrol>().enabled = false;
        gameObject.GetComponent<Agro>().enabled = false;
        
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

}
