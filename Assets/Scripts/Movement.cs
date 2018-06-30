using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    static float speed = 5f;

    public float speedH = 5.0f;
    public float speedV = 5.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    void Move()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    public static float GetSpeed()
    {
        return speed;
    }

    public static void SetSpeed (float value)
    {
        speed = value;
    }
}
