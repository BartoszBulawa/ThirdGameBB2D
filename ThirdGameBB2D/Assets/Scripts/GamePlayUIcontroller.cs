using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIcontroller : MonoBehaviour
{
    public void RestartGame()
    {
        //I can use this one below as well
        //SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
