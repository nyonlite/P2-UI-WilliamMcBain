using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private ItemData type;
    [SerializeField] private GameManager manager;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager inventory = other.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                bool pickedUp = inventory.PickUp(type);
                if (pickedUp)
                {
                    Player player = other.GetComponent<Player>();
                    if (gameObject.name == "CherryPotion")
                    {
                        player.cherryGet = true;
                    }
                    else if (gameObject.name == "MelonBoots")
                    {
                        player.melonGet = true;
                    }
                    else if (gameObject.name == "KiwiCoin")
                    {
                        player.kiwi0Get = true;
                    }
                    else if (gameObject.name == "KiwiCoin (1)")
                    {
                        player.kiwi1Get = true;
                    }
                    else if (gameObject.name == "KiwiCoin (2)")
                    {
                        player.kiwi2Get = true;
                    }
                    else if (gameObject.name == "KiwiCoin (3)")
                    {
                        player.kiwi3Get = true;
                    }
                    else if (gameObject.name == "KiwiCoin (4)")
                    {
                        player.kiwi4Get = true;
                    }
                    if (type.Type() == ItemType.Coin)
                    {
                        Debug.Log(type.Type());
                        manager.AddGold(1);
                    }
                        
                    
                        Destroy(gameObject);
                    
                }
            }
        }
    }


}

