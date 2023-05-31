using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTree : MonoBehaviour
{
    
    public GameObject Tree;
    public List<Transform> SpawnTree;
    
    // Start is called before the first frame update
    void Start()
    { 
            SpawnTree = new List<Transform>(SpawnTree);
        
        StartCoroutine(TreeSpawn(8));
    }

    IEnumerator TreeSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        for (int i = 0; i < SpawnTree.Count; i++)
        {
            var spawn = Random.Range(0, SpawnTree.Count);
            Instantiate(Tree, SpawnTree[spawn].transform.position, SpawnTree[spawn].transform.rotation);
            SpawnTree.RemoveAt(spawn);
        }
        Start();
    }
}
