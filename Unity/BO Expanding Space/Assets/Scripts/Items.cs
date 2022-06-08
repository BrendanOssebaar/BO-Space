using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PolygonCollider2D))]
public class Items : MonoBehaviour
{
    [SerializeField]
    private enum InteractionType { WoodFuel,LeafFuel,StickFuel,CoalFuel,RoditeFuel,Leave,Coalpile,Tree}
    [SerializeField]
    private InteractionType type;
    [SerializeField]
    private GameObject Coal;
    [SerializeField]
    private GameObject Leaf;
    [SerializeField]
    private GameObject rodite;
    [SerializeField]
    private GameObject stick;
    [SerializeField]
    private GameObject wood;

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 6;
    }

    public void Interact()
    {
        switch(type)
        {
            case InteractionType.LeafFuel:
                // leaf
                Debug.Log("Leaf");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<Player>().AddFuel(1);
                Destroy(gameObject);
                break;
            case InteractionType.StickFuel:
                Debug.Log("Stick");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<Player>().AddFuel(5);
                Destroy(gameObject);
                break;
            case InteractionType.WoodFuel:
                Debug.Log("Wood");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<Player>().AddFuel(10);
                Destroy(gameObject);
                break;
            case InteractionType.CoalFuel:
                Debug.Log("Coal");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<Player>().AddFuel(50);
                Destroy(gameObject);
                break;
            case InteractionType.RoditeFuel:
                Debug.Log("Rodite");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<Player>().AddFuel(250);
                Destroy(gameObject);
                break;
            case InteractionType.Leave:
                Debug.Log("Leave");
                leave_planet link = gameObject.GetComponent<leave_planet>();
                link.leave();
                break;
            case InteractionType.Coalpile:
                resource_spawner interaction = gameObject.GetComponent<resource_spawner>();
                interaction.SpawnCoals();
                break;
            case InteractionType.Tree:
                resource_spawner interaction2 = gameObject.GetComponent<resource_spawner>();
                interaction2.SpawnWood();
                resource_spawner interaction3 = gameObject.GetComponent<resource_spawner>();
                interaction3.SpawnLeaves();
                resource_spawner interaction4 = gameObject.GetComponent<resource_spawner>();
                interaction4.SpawnSticks();
                break;
            default:
                Debug.Log("NULL");
                break;
        }
    }


}
