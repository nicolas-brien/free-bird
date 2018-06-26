using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speedH = 5.0f;
    public float speedV = 5.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start () {
        print("this is a test");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.Translate(0, 0, 10f * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.Translate(0, 0, -10f * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.Translate(-10f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Translate(10f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(0, 10f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (transform.position.y > 1)
                transform.Translate(0, -10f * Time.deltaTime, 0);
        }

        if (Input.GetMouseButton(1))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
