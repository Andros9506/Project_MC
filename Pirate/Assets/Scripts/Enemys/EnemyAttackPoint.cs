using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackPoint : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayer;
    public int attackDamage = 20;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    // Update is called once per frame
    

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Time.time >= nextAttackTime)
        {
            if (collision.gameObject.name == "Player")
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }

        }
    }*/
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Time.time >= nextAttackTime)
        {
            if (collision.gameObject.name == "Player")
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }

        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<Player_Stats>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
