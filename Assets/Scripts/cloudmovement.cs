using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmovement : MonoBehaviour {

    public int speed;
    public GameObject cloud;
    public float duration;

	// Use this for initialization
	void Start () {
        Vector3 direction = new Vector3(speed, 0, 0);
       cloud.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        Invoke("destroy",duration);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void destroy()
    {
        Destroy(this.gameObject);
    }
}
