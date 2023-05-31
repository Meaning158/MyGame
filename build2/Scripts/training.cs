using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class training : MonoBehaviour
{
    public GameObject Text;
    public GameObject SpawnTree;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnTree.SetActive(true);
        Text.SetActive(true);
    }
}
