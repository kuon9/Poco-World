using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public string levelSelectMenu;
    public GameObject mainmenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NewGame()
    {
        StartCoroutine(FadingToLevelOne());
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT QUIT");
    }


    public void LevelSelect()
    {
        //StartCoroutine(FadingToLevels());
        SceneManager.LoadScene(levelSelectMenu);   
    }



    IEnumerator FadingToLevelOne()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        // Healthbar.SetActive(true);
        // Healthtext.SetActive(true);
        SceneManager.LoadScene(newGameScene);
    }


}
