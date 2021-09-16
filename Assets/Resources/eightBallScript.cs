using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eightBallScript : MonoBehaviour
{
    public GameObject ballText;
    int size;
    static bool isFlipped = false;
    static string strPhrase = "";
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
        //flipped and isFlipped = do Nothing
        //flipped and !isFlipped = Change phrase / empty text / change isFlipped to true
        //not flipped and isFlipped = isFlipped to false / Display text
        //not flipped and !isFlipped = do Nothing

        //print("Transform: " + transform.up.y + "\n");
        if (transform.up.y < 0f && !isFlipped){
            print("Transform: " + transform.up.y + "\n");
            isFlipped = true;
            int num = Random.Range(0, size);
            strPhrase = phrase[num];  
            ballText.GetComponent<TextMeshPro>().text = "";
        }

        else if(transform.up.y >= 0f && isFlipped){
            print("Transform in else if");
            ballText.GetComponent<TextMeshPro>().text = strPhrase;
            isFlipped = false;
        }
    }
}
