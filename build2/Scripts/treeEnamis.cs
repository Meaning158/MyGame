using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeEnamis : MonoBehaviour
{
    public int maxHealth ;
    public int damage = 25;
    public Animator animator;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth hero1 = hitInfo.GetComponent<PlayerHealth>();
        if (hero1 != null)
        {
            hero1.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
