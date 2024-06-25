using System;
    using System.Collections;
    using System.Collections.Generic;
    using Unity.Mathematics;
    using Unity.VisualScripting;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class Event_Handler : MonoBehaviour, IPointerDownHandler
    {
        //object references
        public GameObject Tenant_1;
        public GameObject Document_1;
        //bool variables
        public bool isAnTenantPresent = false;
        public bool isDocumentSpawned = false;
        public bool isDone = false;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        //Give back documents
        public void OnPointerDown(PointerEventData eventData)
        {
            if (gameObject.tag == "Document")
            {
                Destroy(gameObject);
            }
        }
        public void TenantsArriving()
        {
            if (Document_1 == null && Tenant_1 == null)
            {
                Document_1 = Instantiate(Document_1, transform.position, quaternion.identity);
                Debug.Log("hjuj");
                Tenant_1 = Instantiate(Tenant_1, transform.position, quaternion.identity);
                Debug.Log("hjujujuj");
            }
        }
    }