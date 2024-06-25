using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ID_Generator : MonoBehaviour
{
    public GameObject document;
    public Transform spawnPoint;
    public TextMeshPro FirstName;
    public TextMeshPro LastName;
    public TextMeshPro CityOfBorn;
    List<string> firstName = new List<string>{"John", "Jenny", "Barbara", "Thomas", "Jimmy", "Michael", "Jessica", "William", "Emily", "James", "Sarah", "Christopher",
    "Ashley", "Matthew", "Jennifer", "Joshua", "Amanda", "Daniel", "Megan", "David", "Rachel", "Andrew", "Lauren", "Samantha", "Joseph", "Charles", "Robert", "Benjamin",
    "Alexander", "Henry", "Samuel", "Richard", "Edward", "Nicholas", "Jonathan", "Anthony", "Stephen", "George", "Mark"};
    List<string> lastName = new List<string>{"Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez",
    "Gonzalez", "Wilson", "Anderson", "Moore", "Lee", "Perez", "White", "Harris", "Clark", "Walker", "Wright", "Scott", "Adams", "Baker", "Nelson", "Carter",
    "Phillips", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Morris", "Rogers", "Reed", "Cook", "Morgan"};
    List<string> cityOfBorn = new List<string>() { "Warsaw", "Krakow", "Gdansk", "Wroclaw", "Poznan", "Szczecin", "Lodz", "Lublin", "Bialystok", "Katowice", "Gdynia", "Torun",
    "Rzeszow", "Bydgoszcz", "Kielce", "Olsztyn", "Opole", "Zielona Gora", "Gliwice", "Plock" };
    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnID();
    }
    public void GenerateID()
    {
        int firstNameIndex = random.Next(firstName.Count);
        int lastNameIndex = random.Next(lastName.Count);
        int cityIndex = random.Next(cityOfBorn.Count);

        FirstName.text = firstName[firstNameIndex];
        LastName.text = lastName[lastNameIndex];
        CityOfBorn.text = cityOfBorn[cityIndex];

        Instantiate(document, spawnPoint.position, spawnPoint.rotation);
        
    }
    public void SpawnID()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GenerateID();
        }
    }
}
