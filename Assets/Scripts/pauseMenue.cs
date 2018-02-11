using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenue : MonoBehaviour {

   
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Quit()
    {
        Application.Quit();
    }
    public void Reload()
    {
        SceneManager.LoadScene("Game");
        PlayerController.isover = false;

        Debug.Log("isover true");

    }

    public void resume()
    {
        Time.timeScale = 1f;

    }
    public void OnPause()
    {


        Time.timeScale = 0f;
    }

    public void menue()
    {
        SceneManager.LoadScene("StartMenue");
        PlayerController.isover = false;
    }
}
