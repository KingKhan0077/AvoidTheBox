using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameUI : MonoBehaviour {
    public static MainGameUI instance;
    public GameObject gameover;
    public GameObject ingame;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EndGame()
    {
        gameover.SetActive(true);
        ingame.SetActive(false);
        
    }
}
