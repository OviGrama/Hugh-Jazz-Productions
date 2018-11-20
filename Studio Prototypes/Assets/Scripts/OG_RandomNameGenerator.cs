using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_RandomNameGenerator : MonoBehaviour {

    public string[] FirstNamesList;
    public string[] LastNamesList;
    public string FirstName;
    public string LastName;

    public TextMesh FirstNameText;
    public TextMesh LastNameText;
    // Use this for initialization
    void Start () {
        FirstName = FirstNamesList[Random.Range(0, FirstNamesList.Length)];
        LastName = LastNamesList[Random.Range(0, LastNamesList.Length)];
        FirstNameText.text = FirstName.ToString();
        LastNameText.text = LastName.ToString();

    }
}
