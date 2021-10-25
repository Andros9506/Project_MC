using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    public int maxHeath = 100;
    public float maxStamina = 100;
    public int currentHealth;
    public float currentStamina;
    public float pointIncreasePerSecond = 1f;
    public HealthBar healthBar;
    public StaminaBar staminaBar;
    private float ActionStaminaUsed;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHeath;
        currentStamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(20);
            UseStamina(20);
        }
        if (currentStamina < maxStamina)
        {
            currentStamina += pointIncreasePerSecond * Time.deltaTime;
            staminaBar.SetStamina(currentStamina);
        }
        if(currentStamina > maxStamina)
        {
            currentStamina = maxStamina;
        }
       
    }

    public void Heal(int heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHeath)
        {
            currentHealth = maxHeath;
        }
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void UseStamina (float stamina)
    {
        //Debug.Log(stamina);
        currentStamina -= stamina;
        currentStamina -= this.ActionStaminaUsed;
        staminaBar.SetStamina(currentStamina);
    }

    

}
