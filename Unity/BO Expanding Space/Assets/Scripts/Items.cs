using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PolygonCollider2D))]
public class Items : MonoBehaviour
{
    [SerializeField]
    public enum InteractionType { WoodFuel,LeafFuel,StickFuel,CoalFuel,RoditeFuel,Leave,Coalpile,Tree}
    [SerializeField]
    public InteractionType type;
    public int amount;
   
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
                // Debug.Log("Leaf");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<PlanetStats>().AddFuel(1);
                Destroy(gameObject);
                break;
            case InteractionType.StickFuel:
                // Debug.Log("Stick");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<PlanetStats>().AddFuel(5);
                Destroy(gameObject);
                break;
            case InteractionType.WoodFuel:
                // Debug.Log("Wood");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<PlanetStats>().AddFuel(10);
                Destroy(gameObject);
                break;
            case InteractionType.CoalFuel:
                // Debug.Log("Coal");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<PlanetStats>().AddFuel(50);
                Destroy(gameObject);
                break;
            case InteractionType.RoditeFuel:
                // Debug.Log("Rodite");
                FindObjectOfType<Pickup>().PickUpItem(gameObject);
                FindObjectOfType<PlanetStats>().AddFuel(250);
                Destroy(gameObject);
                break;
            case InteractionType.Leave:
                // Debug.Log("Leave");
                leave_planet link = gameObject.GetComponent<leave_planet>();
                link.leave();
                break;
            case InteractionType.Coalpile:
                resource_spawner interaction = gameObject.GetComponent<resource_spawner>();
                Destroy(gameObject);
                interaction.SpawnCoals();
                break;
            case InteractionType.Tree:
                resource_spawner interaction2 = gameObject.GetComponent<resource_spawner>();
                interaction2.SpawnWood();
                resource_spawner interaction3 = gameObject.GetComponent<resource_spawner>();
                interaction3.SpawnLeaves();
                resource_spawner interaction4 = gameObject.GetComponent<resource_spawner>();
                interaction4.SpawnSticks();
                Destroy(gameObject);
                break;
            default:
                // Debug.Log("NULL");
                break;
        }
    }
    public Sprite GetSprite()
    {
        switch(type)
        {
            default:
            case InteractionType.CoalFuel:   return ItemAssets.Instance.Coal;
            case InteractionType.LeafFuel:   return ItemAssets.Instance.Leaf;
            case InteractionType.RoditeFuel: return ItemAssets.Instance.Rodite;
            case InteractionType.StickFuel:  return ItemAssets.Instance.Stick;
            case InteractionType.WoodFuel:   return ItemAssets.Instance.Wood;
        }
    }


}
