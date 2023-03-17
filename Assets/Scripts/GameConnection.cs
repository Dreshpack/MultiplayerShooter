using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConnection : MonoBehaviour
{
    private const string GAME_NAME_SCENE = "Game";
    private const string MAIN_MANU_SCENE_NAME = "MainMenu";

    public void Host()
    {
        PlayerPrefs.SetString("connection type", "host");
        SceneManager.LoadScene(GAME_NAME_SCENE);
        SceneManager.UnloadSceneAsync(MAIN_MANU_SCENE_NAME);
    }

    public void Connect()
    {
        PlayerPrefs.SetString("connection type", "connected");
        SceneManager.LoadScene(GAME_NAME_SCENE);
        SceneManager.UnloadSceneAsync(MAIN_MANU_SCENE_NAME);
    }
}
