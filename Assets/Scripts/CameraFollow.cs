using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	

    public GameObject ball;
    Vector3 offset;
    public float LurpRate;
    public bool GameOver;

    // Use this for initialization
    void Start()
    {

        offset = ball.transform.position - transform.position;
        GameOver = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (!GameOver)
        {
            Follow();
        }

    }
    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos = Vector3.Lerp(pos, targetPos, LurpRate * Time.deltaTime);
        transform.position = pos;
    }
}
