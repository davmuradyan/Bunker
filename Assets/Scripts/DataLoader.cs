using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class DataLoader : MonoBehaviour {
    public GameData gameData;

    void Start() {
        LoadData();

        foreach (string profession in gameData.professions) {
            Debug.Log(profession);
        }
    }

    void LoadData() {
        string path = Application.streamingAssetsPath + "/Data.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            gameData = JsonUtility.FromJson<GameData>(json);
            Debug.Log("Data loaded successfully!");
        } else {
            Debug.LogError("File not found: " + path);
        }
    }
}