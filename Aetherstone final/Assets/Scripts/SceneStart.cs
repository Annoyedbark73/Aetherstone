using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneStart : MonoBehaviour
{
    public Animator Anim;
    public Canvas Canvas;

    // Start is called before the first frame update
    void Start()
    {
        var scene = SceneManager.GetActiveScene();
        if(scene.buildIndex == 1)
        {
            Anim.SetTrigger("Start");
            Debug.Log("pls play bro");
            StartCoroutine(Pause());

        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2.0f);
        Canvas.sortingOrder = 0;
       
    }
}
