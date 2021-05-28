using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        //Calling UnityEngine.Eventsystem library and use function .EventSystem...
        string clickedObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        //Parse is converting string which is representing number and convert it to int. Use Parse only for string including numbers.

        int selectedCharacter = int.Parse(clickedObj);

        GameManager.instance.CharIndex = selectedCharacter;

        SceneManager.LoadScene("Gameplay");

    }
    public static void Quit()
    {
        Application.Quit();
    }
}
