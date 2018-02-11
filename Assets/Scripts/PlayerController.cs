using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    GameObject player;
    public static PlayerController instance;
    public int speed;
    public int xmin, xmax;
    public int Health;
   public static bool isover;

    public GameObject gameover;
    public GameObject ingame;

    private int finId1 = -1; //id finger for cancel touch event
    private int finId2 = -1;

    // Use this for initialization
    void Start () {
        player = gameObject;
         Input.multiTouchEnabled = true;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (!Application.isMobilePlatform)
        {
            // Get GamePad/Keyboard input.
            if (Input.GetKey(KeyCode.LeftArrow) && !isover)
            {
                goLeft();
                
            }
            else if (Input.GetKey(KeyCode.RightArrow) && !isover)
            {
                goRight();
                
            }

        }
       
    }

    private void goLeft()
    {

        Vector3 direction = new Vector3(speed,0,0);
         player.GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        //transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);


    }
    private void goRight()
    {

         Vector3 direction = new Vector3(speed, 0, 0);
         player.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        // transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
    private void menue()
    {
        if (transform.position.x > xmin)
        {
            Vector3 direction = new Vector3(speed, 0, 0);
            player.GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        }
        else {

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject Enemy = collision.gameObject;
        if (Enemy.tag == "enemy")
        {
            Health = Health - 1;
            if (Health == 0)
            {
                isover = true;
                // MainGameUI.instance.EndGame();
                EndGame();

            }
        }
    }
    public void EndGame()
    {
        gameover.SetActive(true);
        ingame.SetActive(false);
    }
}
