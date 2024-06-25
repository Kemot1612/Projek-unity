using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Overlays;
using UnityEditor.Presets;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Computer : MonoBehaviour, IPointerDownHandler
{
    public GameObject Pulpit;
    public GameObject ExitButton;
    public GameObject MailTab;
    public GameObject NotepadTab;
    public GameObject Mailicon;
    public GameObject NotepadIcon;
    private GameObject PulpitClone;
    private GameObject ExitButtonClone;
    private GameObject MailTabClone;
    private GameObject NotepadTabClone;
    private GameObject MailiconClone;
    private GameObject NotepadIconClone;
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
        if (gameObject.tag == "ExitButton")
        {
            ExitComputer();
        }
        
        if (gameObject.tag == "Computer")
        {
            OpenComputer();
        }
        
        if (gameObject.tag == "MailIcon")
        {
            OpenMail();
        }
        if (gameObject.tag == "NotepadIcon")
        {
            OpenNotepad();
        }
    }

    public void OpenComputer()
    {
        if (PulpitClone == null && ExitButtonClone == null && MailiconClone == null && NotepadIconClone == null)
        {
            PulpitClone = Instantiate(Pulpit, transform.position, quaternion.identity);
            Debug.Log("PulpitOpen");
            ExitButtonClone = Instantiate(ExitButton, transform.position, quaternion.identity);
            Debug.Log("ExitButtonOpen");
            MailiconClone = Instantiate(Mailicon, transform.position, quaternion.identity);
            Debug.Log("MailIconOpen");
            NotepadIconClone = Instantiate(NotepadIcon, transform.position, quaternion.identity);
            Debug.Log("NotepadIconOpen");
        }
    }
    public void ExitComputer()
    {
        if (PulpitClone != null)
        {
            Destroy(PulpitClone);
            Debug.Log("PulpitClosed");
        }
        if (ExitButtonClone != null)
        {
            Destroy(ExitButtonClone);
            Debug.Log("ExitButtonClosed");
        }
        if (MailiconClone != null)
        {
            Destroy(MailiconClone);
            Debug.Log("MailIconClosed");
        }
        if (NotepadIconClone != null)
        {
            Destroy(NotepadIconClone);
            Debug.Log("NotepadIconClosed");
        }
        if (MailTabClone != null)
        {
            Destroy(MailTabClone);
            Debug.Log("MailTadClosed");
        }
        if (NotepadTabClone  != null)
        {
            Destroy(NotepadTabClone);
            Debug.Log("NotepadTadClosed");
        }
    }
    public void OpenMail()
    {
        if (MailTabClone == null)
        {
            MailTabClone = Instantiate(MailTab, transform.position, quaternion.identity);
        }
    }
    public void OpenNotepad()
    {
        if (NotepadTabClone == null)
        {
            NotepadTabClone = Instantiate(MailTab, transform.position, quaternion.identity);
        }
    }
}
