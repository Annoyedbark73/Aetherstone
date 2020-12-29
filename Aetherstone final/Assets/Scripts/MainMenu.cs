using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator Transition;
    public void PlayGame()
    {

        Debug.Log("Play");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        //OPEN ZA GATES!!!

     
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        //well...
    }
    public void ExitGame()
    {
        Debug.Log("back");
        SceneManager.LoadScene(0);
        //brings you back to scene 0 othewise known as main menu 
    }

}