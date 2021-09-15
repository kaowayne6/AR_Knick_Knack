using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eightBallScript : MonoBehaviour
{
    public GameObject ballText;
    int size;
    string[] phrase;

    // Start is called before the first frame update
    void Start()
    {
        size = 20;
        phrase = new string[] 
        {
            "It is Certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes.",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };
    }

    // Update is called once per frame
    void Update()
    {
        //print("Transform: " + transform.up.y + "\n");
        if (transform.up.y < -0.9f){
            print("Transform: " + transform.up.y + "\n");
            int num = Random.Range(0, size);
            string randPhrase = phrase[num];  
            ballText.GetComponent<TextMeshPro>().text = randPhrase;
        }
    }
}
