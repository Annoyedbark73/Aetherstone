using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneTransition : MonoBehaviour
{
    
    public Animator transitionAnim;
    public Canvas Canvas;
    public float Seconds;

    public void TransitionStart()
    {
        Canvas.sortingOrder = 1;


        StartCoroutine(LoadScene());//lets the thing inventor get invented by a thing inventor which was probably being invented by a thing inventor


        Debug.Log("Play");//are you playing son?


    }


    IEnumerator LoadScene()//The thing inventor
    {
        transitionAnim.SetTrigger("End");

        yield return new WaitForSeconds(Seconds);//patience is a virtue

        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);



    }
    


   
}
    

