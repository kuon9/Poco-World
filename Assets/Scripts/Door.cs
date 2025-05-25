using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(UseDoor());
            //SceneManager.LoadScene(levelToLoad);
                
        }
    }
    IEnumerator UseDoor()
    {

        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();  
        SceneManager.LoadScene(levelToLoad);  
    }

}
