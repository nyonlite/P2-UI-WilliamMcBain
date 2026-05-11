using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 40;
    public bool cherryGet = false, 
        melonGet = false, 
        kiwi0Get = false, 
        kiwi1Get = false, 
        kiwi2Get = false, 
        kiwi3Get = false, 
        kiwi4Get = false;
    public int dialogueIndex = 0;

    [SerializeField] ItemData cherry, melon, kiwi;
    [SerializeField] Menu menu;
    [SerializeField] InventoryManager manager;
    [SerializeField] GameManager gm;
    
    #region Ui Methods
    public void ChangeLevel(int amount)
    {
        level += amount;
    }
    public void ChangeHealth(int amount)
    { health += amount; }

    #endregion

    void onAwake()
    {
       // manager = GetComponent<InventoryManager>();
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;
        dialogueIndex = data.dialogueIndex;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

        gm.ResetGold();

        manager.ClearInventory();

        #region Item Population
        cherryGet = data.cherryGet;
        if (cherryGet)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Cherry");
            if (obj != null)
            {
                manager.PickUp(cherry);
                Destroy(obj);
            }
            
        }
        melonGet = data.melonGet;
        if (melonGet) {
            GameObject obj = GameObject.FindGameObjectWithTag("Melon");
            if (obj != null)
            {
                manager.PickUp(melon);
                Destroy(obj);
            }
            
        }
        kiwi0Get = data.kiwi0Get;
        if (kiwi0Get)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Kiwi0");
            if (obj != null)
            {
                manager.PickUp(kiwi);
                gm.AddGold(1);
                Destroy(obj);
            }
            
        }
        kiwi1Get = data.kiwi1Get;
        if (kiwi1Get)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Kiwi1");
            if (obj != null) 
            { 
                manager.PickUp(kiwi);
                gm.AddGold(1);
                Destroy(obj);
            }
            
        }
        kiwi2Get = data.kiwi2Get;
        if (kiwi2Get)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Kiwi2");
            if (obj != null)
            {
                manager.PickUp(kiwi); 
                gm.AddGold(1);
                Destroy(obj);
            }
            
        }
        kiwi3Get = data.kiwi3Get;
        if (kiwi3Get)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Kiwi3");
            if (obj != null)
            {
                manager.PickUp(kiwi);
                gm.AddGold(1);
                Destroy(obj);
            }
            
        }
        kiwi4Get = data.kiwi4Get;
        if (kiwi4Get)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Kiwi4");
            if (obj != null)
            {
                manager.PickUp(kiwi);
                gm.AddGold(1);
                Destroy(obj);
            }
            
        }
        #endregion

        menu.Resume();
    }
}
