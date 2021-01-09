using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonScript : MonoBehaviour
{
    public Animator Anim;
    public float back = 2f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(Back());
        }
        else
        {
            StopCoroutine(Back());
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            
        }

        IEnumerator Back()
        {
            Anim.SetTrigger("Welcome");
            yield return new WaitForSeconds(back);
            SceneManager.LoadSceneAsync(0);
            Debug.Log("YAY");

        }
    }
}
