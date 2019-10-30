using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarQuestions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RightAnswer")
        {
            //TODO Duidelijk maken dat het antwoord goed was dmv visual/score/geluid
        }

        if (collision.gameObject.tag == "WrongAnswer")
        {
            //TODO Duidelijk maken dat het antwoord fout was dmv visual/score/geluid
        }

    }
}
