using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnController : MonoBehaviour
{
    public static RespawnController instance;

    private void Awake()
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
    }
    
    private Vector3 respawnPoint;
    [SerializeField] float waitToRespawn;
    [SerializeField] GameObject deathVFX;    

    private GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = BallHealth.instance.gameObject;
        respawnPoint = Player.transform.position;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpawn(Vector3 newPosition)
    {
        respawnPoint = newPosition;
    }

    public void Respawn()
    {
        StartCoroutine(Respawning());    
    }

    public IEnumerator Respawning()
    {
        /* If you put this script on the player, the SetActive(false) will disable the player
        and the script won't continue.*/
        Player.SetActive(false);
        Instantiate(deathVFX, Player.transform.position, Quaternion.identity);
        //Controller.instance.StartFadeToBlack();
        yield return new WaitForSeconds(waitToRespawn);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // UIController.instance.StartFadeFromBlack();
        Player.transform.position = respawnPoint;
        Player.SetActive(true);
        // PlayerHealth.instance.FullHealth();    
    }

}
