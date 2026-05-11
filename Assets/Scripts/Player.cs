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
    #region Ui Methods
    public void ChangeLevel(int amount)
    {
        level += amount;
    }
    public void ChangeHealth(int amount)
    { health += amount; }

    #endregion

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

        cherryGet = data.cherryGet;
        if (cherryGet)
        {
            GameObject.FindGameObjectWithTag("Cherry").SetActive(false);

        }
        melonGet = data.melonGet;
        kiwi0Get = data.kiwi0Get;
        kiwi1Get = data.kiwi1Get;
        kiwi2Get = data.kiwi2Get;
        kiwi3Get = data.kiwi3Get;
        kiwi4Get = data.kiwi4Get;
    }
}
