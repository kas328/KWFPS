using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LobbySceneMove : MonoBehaviour
{
 
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
