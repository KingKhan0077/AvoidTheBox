using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float duration;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    GameObject enemy;

    public void OnTriggerExit(Collider other)
    {
        enemy = this.gameObject;
        if (other.gameObject.tag == "destroyer")
        {
            Invoke("destroy", duration);
        }
    }

    public void destroy()
    {
        Debug.Log(enemy.tag);
        Destroy(enemy);
    }
}
