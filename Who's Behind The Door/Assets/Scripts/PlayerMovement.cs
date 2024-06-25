using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float xValue = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue,yValue,0);
    }
}
