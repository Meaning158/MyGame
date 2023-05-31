using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public AudioClip shoot;
    public Transform FirePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        GetComponent<AudioSource>().PlayOneShot(shoot);
    }
}
