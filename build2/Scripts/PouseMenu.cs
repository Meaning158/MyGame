using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PouseMenu : MonoBehaviour
{
    public AudioClip pouse;
    public AudioClip exit;
    public bool PouseGame;
    public GameObject PouseGameMenu;
    public bool Stop ;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if (PouseGame)
            {
                Resume();
            }
            else
            {
                Pouse();
            }
        }
        
    }
    public void Resume()
    {
        PouseGameMenu.SetActive(false);
        Time.timeScale = 1.0f;
        PouseGame = false;
        GetComponent<AudioSource>().PlayOneShot(pouse);
    }
    public void Pouse()
    {
        PouseGameMenu.SetActive(true);
        Time.timeScale = 0;
        PouseGame = true;
        GetComponent<AudioSource>().PlayOneShot(pouse);
    }
    public void LoadMenu()
    {
        GetComponent<AudioSource>().PlayOneShot(exit);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
        
    }
    public void RestarGame()
    {
        Time.timeScale = 1;
        Stop = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
