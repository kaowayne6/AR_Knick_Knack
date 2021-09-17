using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class eightBallScriptTwo : MonoBehaviour
{
    public GameObject ballText;
    public GameObject knack;
    public AudioSource audioSrc;
    int size;
    static bool isFlipped = false;
    static string strPhrase = "";
    string[] phrase;

    // Start is called before the first frame update
    void Start()
    {
        size = 10;
        //audioSrc = gameObject.GetComponent<AudioSource>();
        phrase = new string[] 
        {
            "Yeah that sounds lit!",
            "Go for it!",
            "Sounds like fun!",
            "Yeah. You got the right idea.",
            "Is that even a question? Yes",
            "eh",
            "Maybe yes? Maybe no?",
            "I couldn't tell you",
            "Doesn't sound good to me",
            "Naw fam."
        };
    }

    // Update is called once per frame
    void Update()
    {
        //flipped and isFlipped = do Nothing
        //flipped and !isFlipped = Change phrase / empty text / change isFlipped to true
        //not flipped and isFlipped = isFlipped to false / Display text
        //not flipped and !isFlipped = do Nothing
        //print("Transform rotx: " + transform.localEulerAngles.x + "\n");
        //print("Transform roty: " + transform.localEulerAngles.y + "\n");
        print("Transform rotz: " + transform.localEulerAngles.z + "\n");

        //print("Transform: " + transform.up.y + "\n");
       // print("isFlipped: " + isFlipped + "\n");
        //transform.up.y < 0
        if (transform.localEulerAngles.z >= 160 && transform.localEulerAngles.z <= 210 && !isFlipped){
            print("in if");
            audioSrc.Play();
            isFlipped = true;
            int num = Random.Range(0, size);
            strPhrase = phrase[num];  
            ballText.GetComponent<TextMeshPro>().text = "";
        }

        else if((transform.localEulerAngles.z < 160 || transform.localEulerAngles.z > 210) && isFlipped){
            print("Transform in else if");
            ballText.GetComponent<TextMeshPro>().text = strPhrase;
            isFlipped = false;
        }
    }
}
