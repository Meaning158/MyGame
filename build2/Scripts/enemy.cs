using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject Baner;
    public Animator animator;
    public int maxHealth = 500;
    public bool invulnerable = false;
     int currentHealth;
    
    void Start()
    {
        currentHealth= maxHealth;
    }
    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        

        if(invulnerable)
        {
            return;
        }

        if (currentHealth < 300)
        {
            GetComponent<Animator>().SetBool("reag", true);

        }

        if (currentHealth < 0)
        {
            Die();
        }
    }
    void Die()
    {
        GetComponent<Animator>().SetBool("isdead", true);
        GetComponent<Collider2D>().enabled = false;
        Destroy(GetComponent<spawnTree>());
        Baner.SetActive(true);
        return;
        

    }
    
}
