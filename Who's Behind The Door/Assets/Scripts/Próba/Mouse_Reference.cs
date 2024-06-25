using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = worldPosition;
    }
}
