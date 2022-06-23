using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resource_spawner : MonoBehaviour
{

    private float radius;
    private Vector2 point;

    public GameObject logs;
    [Range(0, 50)]
    public int aantal_logs;

    public GameObject leaves;
    [Range(0, 50)]
    public int aantal_leaves;

    public GameObject sticks;
    [Range(0, 50)]
    public int aantal_sticks;

    public GameObject coal;
    [Range(0, 50)]
    public int aantal_coal;

    public GameObject gems;
    [Range(0, 50)]
    public int aantal_gems;


    public void SpawnWood()
    {
        for (int i = aantal_logs; i >0; i--)
        {
            Debug.Log("Trees_interaction");
            radius = 1f;
            point = Random.insideUnitCircle * radius + new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            Instantiate(logs, point, Quaternion.identity);
        }
    }
    public void SpawnLeaves()
    {
        for (int i = aantal_leaves; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            radius = 2.4f;
            point = Random.insideUnitCircle * radius + new Vector2(gameObject.transform.position.x, 0.5f+gameObject.transform.position.y);
            Instantiate(leaves, point, Quaternion.identity);
        }
    }
    public void SpawnSticks()
    {
        for (int i = aantal_sticks; i > 0; i--)
        {
            Debug.Log("Trees_interaction");
            radius = 1f;
            point = Random.insideUnitCircle * radius + new Vector2(gameObject.transform.position.x, 1f+gameObject.transform.position.y);
            Instantiate(sticks, point, Quaternion.identity);
        }
    }
    public void SpawnCoals()
    {
        for (int i = aantal_coal; i > 0; i--)
        {
            Debug.Log("Coal_interaction");
            radius = 1f;
            point = Random.insideUnitCircle * radius + new Vector2(gameObject.transform.position.x, 1f+gameObject.transform.position.y);
            Instantiate(coal, point, Quaternion.identity);
        }
    }
    public void SpawnGems()
    {
        for (int i = aantal_gems; i > 0; i--)
        {
            Debug.Log("Gem_interaction");
            radius = 0.2f;
            point = Random.insideUnitCircle * radius + new Vector2(gameObject.transform.position.x, 0.5f+gameObject.transform.position.y);
            Instantiate(gems, point, Quaternion.identity);
        }
    }
}
