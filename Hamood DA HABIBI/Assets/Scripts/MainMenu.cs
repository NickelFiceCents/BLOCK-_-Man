using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SinglePlayer()
    {

    }
    public void Multiplayer()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Debug.Log("QUIT");

        Application.Quit();
    }
    public void Back2MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
