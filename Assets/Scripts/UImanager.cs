using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UImanager : MonoBehaviour {

    public GameObject Sound;
    


   
	

    public void loadGame1()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
    public void Reload()
    {
        SceneManager.LoadScene("Game");
        PlayerController.isover = false;

    }

    
}
