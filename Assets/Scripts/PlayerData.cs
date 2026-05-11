[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public int dialogueIndex;
    public float[] position;
    public bool cherryGet, melonGet, kiwi0Get, kiwi1Get, kiwi2Get, kiwi3Get, kiwi4Get;

    public PlayerData(Player player)
    {
        level = player.level;
        health = player.health;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        cherryGet = player.cherryGet;
        melonGet = player.melonGet;
        kiwi0Get = player.kiwi0Get;
        kiwi1Get = player.kiwi1Get;
        kiwi2Get = player.kiwi2Get;
        kiwi3Get = player.kiwi3Get;
        kiwi4Get = player.kiwi4Get;

        dialogueIndex = player.dialogueIndex;
    }
}
