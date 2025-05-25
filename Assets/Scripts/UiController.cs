using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class UiController : MonoBehaviour
{
    public Image fadeScreen;
    public float fadeSpeed = 2f;
    private bool fadingToBlack, fadingFromBlack;
    public string mainMenuScene;
    [SerializeField] GameObject pauseScreen;
    private PocoWorld pocoWorld;
    private InputAction menu;
    public static bool inMainMenu;
    public static bool isPaused;
    public static bool isTransitioningtoLevel;
    public static UiController instance;
    
        void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
        //this is for pause menu
        pocoWorld = new PocoWorld();
    }

    
    // Start is called before the first frame update
    void Start()
    {
        //inMainMenu = true;    
    }

    private void OnEnable()
    {
        menu = pocoWorld.Menu.Escape;
        menu.Enable();
        menu.performed += Pause; 
    }

    private void OnDisable()
    {
        menu.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if(fadingToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r,fadeScreen.color.g,fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            
            if(fadeScreen.color.a == 1f)
            {
                fadingToBlack = false;    
            }
        }
        else if(fadingFromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r,fadeScreen.color.g,fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));    
            
            if(fadeScreen.color.a == 0f)
            {
                fadingFromBlack = false;
            }
        }            
    }

    public void StartFadeToBlack()
    {
        fadingToBlack = true;
        fadingFromBlack = false;
    }

    public void StartFadeFromBlack()
    {
        fadingToBlack = false;
        fadingFromBlack = true;    
    }


    public void Pause(InputAction.CallbackContext context)
    {
        if(inMainMenu) {return;}
        // inverse
        isPaused = !isPaused;

        if(isPaused)
        {
            ActivateMenu();
            
        }    
        else
        {
            Cursor.visible = false;  
            DeactivateMenu();
        }      
    }


    public void ActivateMenu()
    {
        // Puts whole game in pause
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseScreen.SetActive(true);
        Cursor.visible = true; 
    }

    public void DeactivateMenu()
    {
        // resumes game from pause
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseScreen.SetActive(false);
        isPaused = false;
        Cursor.visible = false;  
    }


  public void GoToMainMenu()
    {
        inMainMenu = true;
        isTransitioningtoLevel = false;
        Time.timeScale = 1f;
        //AudioManager.instance.PlayMainMenuMusicYee();
        // There was no music after going back to mainmenu because AudioListener was disabled when opening up pause menu
        AudioListener.pause = false;
        isPaused = false;
        pauseScreen.SetActive(false);
        //instance = null;
        //Destroy(gameObject);
        SceneManager.LoadScene(mainMenuScene);
        print("Loading Main Menu");    
    }
}
