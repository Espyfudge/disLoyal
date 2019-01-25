using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextMan : MonoBehaviour {
    public Text question;
    private int counter;
    public GameObject cop1;
    public GameObject cop2;
    public GameObject cop3;
    public GameObject button;
    public GameObject evidence;
    public GameObject miniGame;
    public GameObject instructionText;

    // Use this for initialization
    void Start () {
        question.text = "So, you drive a truck for a living?";
	}

    public void countUp()
    {
        counter++;
    }
	
	// Update is called once per frame
	void Update () {
        if (counter == 1)
        {
        	cop1.SetActive(false);
        	cop2.SetActive(true);
            question.text = "Sure, but you haven't answered my question.";
        }

        if (counter == 2)
        {
			cop1.SetActive(true);
        	cop2.SetActive(false);
            question.text = "Alright. Want a cigarette meanwhile?";
        }

        if (counter == 3)
        {
            question.text = "For fuck's sake. Let's be reasonable, help me, help you.";
        }

        if (counter == 4)
        {
        	cop1.SetActive(false);
        	cop3.SetActive(true);
            question.text = "Eat. A. Dick. You. Little. Shit. There's no time for your crap.";
        }
        if (counter == 5)
        {
      		cop3.SetActive(false);
            button.SetActive(false);
            instructionText.SetActive(true);
            evidence.GetComponent<BoxCollider2D>().enabled = true;
            question.text = " ";
            counter = 0;
        }
    }
}
