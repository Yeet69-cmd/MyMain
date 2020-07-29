using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    
    public float MAXHEALTH = 10f;
    float health;
    public Gradient gradient;
    public Image fill;
    public Slider healthSlider;


    // Start is called before the first frame update
    void Start()
    {
        health = MAXHEALTH;

        healthSlider.value = health / MAXHEALTH;
    }



    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
        // UPDATE THE SLIDER
        healthSlider.value = health / MAXHEALTH;
    }

    void Die()
    {
        GetComponent<CharacerController2D>().enabled = false;
        GetComponent<Animator>().SetBool("Dead", true);
    }
    public void GetHealth(float amount)
    {
        health += amount;

        if (health > MAXHEALTH)
        {
            health = MAXHEALTH;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Heal"))
        {
            GetHealth(5);
            Destroy(other.gameObject);
        }
        // UPDATE THE SLIDER
        healthSlider.value = health / MAXHEALTH;


    }
}
