using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 destination = new Vector3(horizontal, 0, vertical);
        GetComponent<Rigidbody>().velocity = destination * speed;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}