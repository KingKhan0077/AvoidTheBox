using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public float spawnDelay = 0.5f;
    public int width, height, thick;
    public bool show;
    public GameObject enemyPrefab;
    public int downfall;
    
    
    // Use this for initialization
    void Start () {
        InvokeRepeating("dosp", 2f,2f);
	}
   
	
	// Update is called once per frame
	void Update () {
        
	}
    void dosp() {
        float x = Random.Range(0, 20);
        if (x < 5 && PlayerController.isover == false)
        {
            spawn();
        }
        else return;

    }

    private void spawn()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity) as GameObject;
       // enemy.GetComponent<Rigidbody>().velocity = new Vector3(0,downfall,0);
        enemy.GetComponent<Rigidbody>().useGravity = true;
    }

}
