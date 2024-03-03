using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPoints : MonoBehaviour
{
    public int MaxHealth = 125;
    public int currentHealth;

    public sliderscript Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        InitialiseHealth();
    }

    public void InitialiseHealth()
    {
        currentHealth = MaxHealth;
        Healthbar.SetMaxHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            /*TODO:
             * Kill Player
             * Restart Game
             */
            Die();

        }
    }

    public void Die()
    {
        /*
         * TODO: Create some nice death affect
         */
        GameManager.Instance.ResetLevel();
    }

}