using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LocalManager : MonoBehaviour
{
    [Header("Scene Names")]
    [SerializeField] string MainGame;
    Button GoBack;

    private void Start() {
        DontDestroyOnLoad(this);
    }

    public void OnNewGameClicked() {
        SceneManager.LoadSceneAsync(MainGame);
    }

    public void LeaveGame() {
        Application.Quit();
    }
}
