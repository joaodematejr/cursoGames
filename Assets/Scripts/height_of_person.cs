using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class height_of_person : MonoBehaviour
{
    public Transform person;
    Text text_interface;
    // Start is called before the first frame update
    void Start()
    {
        text_interface = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Olá Mundo!!!");
        //Debug.Log(person.position.y);
        text_interface.text = Mathf.RoundToInt(person.position.y).ToString();
    }
}
