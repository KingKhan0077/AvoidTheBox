using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmozDraw : MonoBehaviour {

    public int width, height, thick;
    public bool show;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDrawGizmos()
    {
        if (show)
        {
            Gizmos.DrawWireCube(transform.position, new Vector3(width, height, thick));
        }
        else return;
    }
}
