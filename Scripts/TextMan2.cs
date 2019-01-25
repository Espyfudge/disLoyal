using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMan2 : MonoBehaviour
{
    public Text question;
    private int counter;
    public GameObject questionObj;
    public GameObject cop1;
	public GameObject cop2;
	public GameObject cop3;
    public GameObject button;
    public GameObject evidence;
    public GameObject miniGame;
    public GameObject instructionText;

    // Use this for initialization
    void Start()
    {
        question.text = "Your lawyer isn't coming today, so you'll have to talk to me at some point.";
    }

    public void countUp()
    {
        counter++;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
        {
        	cop1.SetActive(false);
        	cop2.SetActive(true);
            question.text = "I hope you're not doing anything stupid.";
        }

        if (counter == 2)
        {
        	cop2.SetActive(false);
        	cop3.SetActive(true);
            question.text = "I'll be back in a bit. Hang tight.";
        }

        if (counter == 3)
        {
            cop3.SetActive(false);
            button.SetActive(false);
            instructionText.SetActive(true);
            questionObj.SetActive(false);
            
            evidence.GetComponent<BoxCollider2D>().enabled = true;
            question.text = " ";
            counter = 0;
        }
        
    }
}