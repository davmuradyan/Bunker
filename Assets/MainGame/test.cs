using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Start() {
        text.text = "Մասնագիտություն";
    }
}
