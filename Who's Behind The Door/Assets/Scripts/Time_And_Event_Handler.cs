    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Unity.Mathematics;
    using Unity.VisualScripting;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class Time_And_Event_Handler : MonoBehaviour
    {
        //object references
        public Text Godziny;
        public Text Minuty;
        public Text Dni;
        //variables
        public float dayLength = 24f;
        public float Minutes = 0f;
        public float Hours = 0f;
        public float hourLenght = 60f;
        public int currentDay = 1;
        public float debugSpeed = 1f;
        //bool variables
        public bool isNight = false;
        public bool isDay = false;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Clock();
            IsDayIsNight();
        }
        void Clock()
        {
            Godziny.text = Mathf.FloorToInt(Hours).ToString();
            Minuty.text = Mathf.FloorToInt(Minutes).ToString();
            Dni.text = currentDay.ToString();

            Minutes = Minutes + Time.deltaTime * debugSpeed;
            if (Minutes >= hourLenght)
            {
                Minutes = 0f;
                Hours = Hours + 1;
            }
            else if (Hours >= dayLength)
            {
                Hours = 1f;
                currentDay = currentDay + 1;
            }
        }
        void IsDayIsNight()
        {
            if (Hours >= 7 && Hours <= 21)
            {
                //Day
                isNight = false;
                isDay = true;
            }
            else
            {
                //Night
                isNight = true;
                isDay = false;
            }
        }
        
    }
