using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool forward = false;
    public bool backwards = false;
    public bool left = false;
    public bool right = false;

    public float movement_speed = 6;

    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")) forward = true;
        if (Input.GetKeyDown("s")) backwards = true;
        if (Input.GetKeyDown("a")) left = true;
        if (Input.GetKeyDown("d")) right = true;



        if (forward) transform.position += Vector3.forward * movement_speed * Time.deltaTime;
        if (backwards) transform.position += Vector3.back * movement_speed * Time.deltaTime;
        if (left) transform.position += Vector3.left * movement_speed * Time.deltaTime;
        if (right) transform.position += Vector3.right * movement_speed * Time.deltaTime;


        if (Input.GetKeyUp("w")) forward = false;
        if (Input.GetKeyUp("s")) backwards = false;
        if (Input.GetKeyUp("a")) left = false;
        if (Input.GetKeyUp("d")) right = false;

    }
}
