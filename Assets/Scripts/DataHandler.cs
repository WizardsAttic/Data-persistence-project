using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataHandler : MonoBehaviour
{

    public static DataHandler Instance;
    public string playerName;
    public int highScore;
    public string highScorePlayerName;

    [System.Serializable]
    class SaveData
    {
        public int highScore;
        public string playerName;
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.highScore = highScore;
        data.playerName = playerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScorePlayerName = data.playerName;
        }
    }

}
