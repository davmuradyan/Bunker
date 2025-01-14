using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Fields")]
    [SerializeField] TextMeshProUGUI prof;
    [SerializeField] TextMeshProUGUI bio;
    [SerializeField] TextMeshProUGUI health;
    [SerializeField] TextMeshProUGUI hobby;
    [SerializeField] TextMeshProUGUI phobia;
    [SerializeField] TextMeshProUGUI pers;
    [SerializeField] TextMeshProUGUI edu;
    [SerializeField] TextMeshProUGUI add;
    [SerializeField] TextMeshProUGUI luggage;

    void Start() {
        GameData Data = GameObject.Find("Data").GetComponent<DataLoader>().gameData;

        prof.text = Data.professions[Random.Range(0, Data.professions.Count)];
        bio.text = Data.biology[Random.Range(0, Data.biology.Count)];
        health.text = Data.health[Random.Range(0, Data.health.Count)];
        hobby.text = Data.hobby[Random.Range(0, Data.hobby.Count)];
        phobia.text = Data.phobia[Random.Range(0, Data.phobia.Count)];
        pers.text = Data.personality[Random.Range(0, Data.personality.Count)];
        edu.text = Data.education[Random.Range(0, Data.education.Count)];
        add.text = Data.additional_information[Random.Range(0, Data.additional_information.Count)];
        luggage.text = Data.luggage[Random.Range(0, Data.luggage.Count)];
    }
}