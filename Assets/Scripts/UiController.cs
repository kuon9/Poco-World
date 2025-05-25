using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    public Image fadeScreen;
    public float fadeSpeed = 2f;
    private bool fadingToBlack, fadingFromBlack;
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
        // this is for pause menu
        //metroidVania = new MetroidVania();
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
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
}
