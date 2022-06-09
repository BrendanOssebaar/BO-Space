using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resource_spawner : MonoBehaviour
{
    public GameObject logs;
    [Range(0.1f, 50.0f)]
    public float aantal_logs;

    public GameObject leaves;
    [Range(0.1f, 50.0f)]
    public float aantal_leaves;

    public GameObject sticks;
    [Range(0.1f, 50.0f)]
    public float aantal_sticks;

    public GameObject coal;
    [Range(0.1f, 50.0f)]
    public float aantal_coal;

    public GameObject gems;
    [Range(0.1f, 50.0f)]
    public float aantal_gems;

    // Start is called before the first frame update
    public void SpawnWood()
    {
        for (int i = (int)aantal_logs; i >0; i--)
        {
            Debug.Log("Trees_interaction");
            Instantiate(logs, new Vector3(~1, ~1, ~1), Quaternion.identity);
        }
        
    }
    public void SpawnLeaves()
    {
        for (int i = (int)aantal_leaves; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            Instantiate(leaves, new Vector3(~1, ~1, ~1), Quaternion.identity);
        }

    }
    public void SpawnSticks()
    {
        for (int i = (int)aantal_sticks; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            Instantiate(sticks, new Vector3(~1, ~1, ~1), Quaternion.identity);
        }

    }
    public void SpawnCoals()
    {
        for (int i = (int)aantal_coal; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            Instantiate(coal, new Vector3(~1, ~1, ~1), Quaternion.identity);
        }

    }
    public void SpawnGems()
    {
        for (int i = (int)aantal_gems; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            Instantiate(gems, new Vector3(~1, ~1, ~1), Quaternion.identity);
        }

    }
}
