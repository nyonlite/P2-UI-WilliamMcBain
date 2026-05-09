using System;
using System.IO;
using UnityEngine;

// My SaveManager is a Serializable POCO. It contains the default values of the fields
// to be saved and the filepath which itself is not saved since it's static
// Save() simply saves this while Load() load an instance of SaveManager from json and
// returns it (or returns a new one if the file was not found). 
// Load() is called only a single time, by the GameManager's Start(), and its return 
// value is the stored in a static field for global access. Once GameManager is done 
// with its Start(), it sends an event and this is when classes that need to act on a
// saved value do their thing.

[Serializable]
public class SaveManager
{
    private static string saveFile = Application.persistentDataPath + Path.DirectorySeparatorChar + "Save.json";

    // default values

    public Vector3 loadAt; // default is 0, 0, 0
    public float timer = 0f;



    public void Save()
    {
        File.WriteAllText(saveFile, JsonUtility.ToJson(this));
    }

    public static SaveManager Load() // add save file ID as an argument once I have a save menu
    {
        if (File.Exists(saveFile))
        {
            return JsonUtility.FromJson<SaveManager>(File.ReadAllText(saveFile));
        }
        else
        {
            return new SaveManager();
        }
    }
}