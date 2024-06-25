using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Sprite RightOpened;
    public Sprite RightClosed;
    public Sprite LeftOpened;
    public Sprite LeftClosed;
    public Sprite MiddleOpened;
    public Sprite MiddleClosed;
    public Sprite BottomLeftOpened;
    public Sprite BottomLeftClosed;
    bool isRightClosed = true;
    bool isLeftClosed = true;
    bool isMiddleClosed = true;
    bool isBottomLeftClosed = true;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.tag == "RoletaSrodek")
        {
            if (isMiddleClosed == false)
            {
            sr.sprite = MiddleOpened;
            isMiddleClosed = true;
            Debug.Log("Opened");
            }
            else
            {
            sr.sprite = MiddleClosed;
            isMiddleClosed = false;
            Debug.Log("Closed");
            }
        }
        if (gameObject.tag == "RoletaPrawo")
        {
            if (isRightClosed == false)
            {
            sr.sprite = RightOpened;
            isRightClosed = true;
            Debug.Log("Opened");
            }
            else
            {
                sr.sprite = RightClosed;
                isRightClosed = false;
                Debug.Log("Closed");
            }
        }
        if (gameObject.tag == "RoletaLewo")
        {
            if (isLeftClosed == false)
            {
            sr.sprite = LeftOpened;
            isLeftClosed = true;
            Debug.Log("Opened");
            }
            else
            {
            sr.sprite = LeftClosed;
            isLeftClosed = false;
            Debug.Log("Closed");
            }
        }
        if (gameObject.tag == "RoletaLewoDol")
        {
            if (isBottomLeftClosed == false)
            {
            sr.sprite = BottomLeftOpened;
            isBottomLeftClosed = true;
            Debug.Log("Opened");
            }
            else
            {
                sr.sprite = BottomLeftClosed;
                isBottomLeftClosed = false;
                Debug.Log("Closed");
            }
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
