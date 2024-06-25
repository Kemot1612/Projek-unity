using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HousingHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.tag == "Strozowka")
        {
            SceneManager.LoadScene(0);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
