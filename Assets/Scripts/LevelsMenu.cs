using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public string gameScene;
   

    public void LevelOne()
    {
        StartCoroutine(FadingToLevelOne());
    }

    IEnumerator FadingToLevelOne()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;
        SceneManager.LoadScene(2);
    }

    public void LevelTwo()
    {
       StartCoroutine(FadingToLevelTwo());
    }

    IEnumerator FadingToLevelTwo()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;
        SceneManager.LoadScene(3);
    }


    public void LevelThree()
    {
        StartCoroutine(FadingToLevelThree());;
    }
   
    IEnumerator FadingToLevelThree()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;
        SceneManager.LoadScene(4);
    }
    
    public void LevelFour()
    {
        StartCoroutine(FadingToLevelFour());
    }
    
    IEnumerator FadingToLevelFour()
    {
        // Deleting all stored player information.
        PlayerPrefs.DeleteAll();
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;     
        SceneManager.LoadScene(5);
    }
   
    public void LevelFive()
    {
        StartCoroutine(FadingToLevelFive());
    }
    
    IEnumerator FadingToLevelFive()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;     
        SceneManager.LoadScene(6);
    }
   
    public void LevelSix()
    {
        StartCoroutine(FadingToLevelSix());
    }
    
    IEnumerator FadingToLevelSix()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;   
        SceneManager.LoadScene(7);
    }
    
    public void LevelSeven()
    {
        StartCoroutine(FadingToLevelSeven());
    }
    
    IEnumerator FadingToLevelSeven()
    {
        UiController.instance.StartFadeToBlack();
        yield return new WaitForSeconds(2f);
        UiController.instance.StartFadeFromBlack();
        UiController.isTransitioningtoLevel = true;
        UiController.inMainMenu = false;   
        SceneManager.LoadScene(8);
    }
    
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(gameScene);
    }
}