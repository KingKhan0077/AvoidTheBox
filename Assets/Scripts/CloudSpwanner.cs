using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpwanner : MonoBehaviour {

    public  GameObject cloud;
    public float duration;
    public float repeatRate;

    // Use this for initialization
    void Start () {
        InvokeRepeating("spwan", duration, repeatRate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void spwan() {

        Instantiate(cloud, transform.position, Quaternion.identity);
    }
}
