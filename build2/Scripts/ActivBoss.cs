using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivBoss : MonoBehaviour
{
    public GameObject ActBoss;
    public GameObject WollSpawn;
    public GameObject boss0;
    public Collider2D collision;
    public GameObject Boss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(boss0);
        Boss.SetActive(true);
        WollSpawn.SetActive(true);
       
    }
}
