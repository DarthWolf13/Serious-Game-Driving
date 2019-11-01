using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarQuestions : MonoBehaviour
{
    public GameObject RightMessage;
    public GameObject WrongMessage;

    // Start is called before the first frame update
    void Start()
    {
        RightMessage.SetActive(false);
        WrongMessage.SetActive(false);
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
            Debug.Log("Right");
            StartCoroutine(ShowMessageRight());
        }

        if (collision.gameObject.tag == "WrongAnswer")
        {
            //TODO Duidelijk maken dat het antwoord fout was dmv visual/score/geluid
            Debug.Log("Wrong");
            StartCoroutine(ShowMessageWrong());
        }
    }

    IEnumerator ShowMessageRight()
    {
        RightMessage.SetActive(true);
        yield return new WaitForSeconds(3);
        RightMessage.SetActive(false);
    }

    IEnumerator ShowMessageWrong()
    {
        WrongMessage.SetActive(true);
        yield return new WaitForSeconds(3);
        WrongMessage.SetActive(false);
    }
}
