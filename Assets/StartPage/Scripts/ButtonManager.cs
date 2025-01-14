using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalManager : MonoBehaviour
{
    [Header("Scene Names")]
    [SerializeField] string MainGame;

    private void Start() {
        DontDestroyOnLoad(this);
    }

    public void OnNewGameClicked() {
        SceneManager.LoadSceneAsync(MainGame);
    }
}
