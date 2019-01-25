using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileTamperingGameScript : MonoBehaviour {
	public GameObject tamperingGame;
	public GameObject gcManager;
	private GCManager gcMan;
	public GameObject gameWin;
	public GameObject evidence;
	public Text storyText;
	public int counter;
	public float p1Score;
	public float p2Score;
    private int answerValue;
    private int randomVal;
    private string word1;
    private string word2;
    private string word3;
    private string word4;
    public Text button1Text;
    public Text button2Text;
    public Text button3Text;
    public Text button4Text;
	private int p2Counter = 1;
    string[] bWords = new string[13];

	public bool finished2;

	public GameObject audio1;
	public GameObject audio2;
	public GameObject audio3;

    // Use this for initialization
    void Start()
    {
        randomVal = Random.Range(0, 4);
        changeButtonTexts();
        linkWords();
		p1Score = 50.0f;
		p2Score = 50.0f;
        counter = 0;
		bWords[0] = "<color=#ff0000ff><b>thoroughly</b></color>";
        bWords[1] = "truly";
        bWords[2] = "two";
        bWords[3] = "three";
        bWords[4] = "tools";
        bWords[5] = "went";
        bWords[6] = "fooled";
        bWords[7] = "accompanying";
        bWords[8] = "impersonated";
        bWords[9] = "murdered";
        bWords[10] = "plan";
        bWords[11] = "evade";
        bWords[12] = "escape";

		PlayerScore.SecondDay = true;
        
		gcMan = gcManager.GetComponent<GCManager> ();
    }

    public void PlusCounter()
    {
		int whichAudio = Random.Range (1, 4);
		if (whichAudio == 1) {
			audio1.GetComponent<AudioSource> ().Play ();
		}
		if (whichAudio == 2) {
			audio2.GetComponent<AudioSource> ().Play ();
		}
		if (whichAudio == 3) {
			audio3.GetComponent<AudioSource> ().Play ();
		}
        counter++;

    }

    public void changeBoldWord1()
    {
        bWords[(counter-1)] = button1Text.text;
        if (randomVal == 0)
        {
			p1Score -= 3.0f;
			p2Score += 3.0f;
           //changeScore();
        }
        if (randomVal == 3)
        {
			p1Score += 3.0f;
			p2Score -= 3.0f;
            //changeScore();
        }
        changeButtonTexts();
    }
    public void changeBoldWord2()
    {
        bWords[(counter-1)] = button2Text.text;
        if (randomVal == 1)
        {
			p1Score -= 3.0f;
            p2Score += 3.0f;
           //changeScore();
        }
        if (randomVal == 0)
        {
            p1Score += 3.0f;
			p2Score -= 3.0f;
            //changeScore();
        }
        changeButtonTexts();
    }
    public void changeBoldWord3()
    {
        bWords[(counter-1)] = button3Text.text;
        if (randomVal == 2)
        {
			p1Score -= 3.0f;
			p2Score += 3.0f;
            //changeScore();
        }
        if (randomVal == 1)
        {
			p1Score += 3.0f;
			p2Score -= 3.0f;
            //changeScore();
        }
        changeButtonTexts();
    }
    public void changeBoldWord4()
    {
        bWords[(counter-1)] = button4Text.text;
        if (randomVal == 3)
        {
			p1Score -= 3.0f;
            p2Score += 3.0f;
           // changeScore();
        }
        if (randomVal == 2)
        {
			p1Score += 3.0f;
            p2Score -= 3.0f;
            //changeScore();
        }

        changeButtonTexts();
    }

//    void changeScore()
//    {
//        score1.text = "score: " + p1Score;
//        score2.text = "score: " + p2Score;
//
//    }

    void linkWords()
    {
        if (randomVal == 0)
        {
            button1Text.text = word1;
            button2Text.text = word2;
            button3Text.text = word3;
            button4Text.text = word4;

        }
        if (randomVal == 1)
        {
            button1Text.text = word4;
            button2Text.text = word1;
            button3Text.text = word2;
            button4Text.text = word3;
        }
        if (randomVal == 2)
        {
            button1Text.text = word3;
            button2Text.text = word4;
            button3Text.text = word1;
            button4Text.text = word2;
        }
        if (randomVal == 3)
        {
            button1Text.text = word2;
            button2Text.text = word3;
            button3Text.text = word4;
            button4Text.text = word1;
        }
    }

    void changeButtonTexts()
    {
        randomVal = Random.Range(0, 4);
        if (counter == 0)
        {
			bWords[0] = "<color=#ff0000ff><b>thoroughly</b>";
            word1 = "not";
            word2 = "badly";
            word3 = "carefully";
            word4 = "well";
            
        }
        if (counter == 1)
        {
			bWords[1] ="<color=#ff0000ff><b>truly</b></color>";
            word1 = "at all";
            word2 = "really";
            word3 = "doubtlessly";
            word4 = "well";
           
        }
        if (counter == 2)
        {
			bWords[2] = "<color=#ff0000ff><b>two</b></color>";
            word1 = "zero";
            word2 = "many";
            word3 = "a few";
            word4 = "multiple";
            
        }
        if (counter == 3)
        {
			bWords[3] = "<color=#ff0000ff><b>three</b></color>";
            word1 = "no";
            word2 = "five";
            word3 = "a few";
            word4 = "various";
           
        }
        if (counter == 4)
        {
			bWords[4] = "<color=#ff0000ff><b>tools</b></color>";
            word1 = "invitation";
            word2 = "weapons";
            word3 = "clothes";
            word4 = "car";
            
        }
        if (counter == 5)
        {
			bWords[5] = "<color=#ff0000ff><b>went</b></color>";
            word1 = "walked";
            word2 = "sneaked";
            word3 = "moved";
            word4 = "ran";
            
        }
        if (counter == 6)
        {
			bWords[6] = "<color=#ff0000ff><b>fooled</b></color>";
            word1 = "convinced";
            word2 = "asked";
            word3 = "tricked";
            word4 = "deceived";
            
        }
        if (counter == 7)
        {
			bWords[7] = "<color=#ff0000ff><b>accompanying</b></color>";
            word1 = "seeing";
			word2 = "coming with";
			word3 = "joining";
			word4 = "following";
            
        }
        if (counter == 8)
        {
			bWords[8] = "<color=#ff0000ff><b>impersonated</b></color>";
            word1 = "looked like";
            word2 = "mimicked";
            word3 = "asked";
            word4 = "seduced";
            
        }
        if (counter == 9)
        {
			bWords[9] = "<color=#ff0000ff><b>committed</b></color>";
            word1 = "witnessed the murder of";
            word2 = "tortured";
            word3 = "left";
            word4 = "briefly spoke to";
           
        }
        if (counter == 10)
        {
			bWords[10] = "<color=#ff0000ff><b>plan</b></color>";
            word1 = "way";
            word2 = "evasion";
            word3 = "run";
            word4 = "route";
            
        }
        if (counter == 11)
        {
			bWords[11] = "<color=#ff0000ff><b>evade</b></color>";
            word1 = "alert";
            word2 = "escape";
            word3 = "run towards";
            word4 = "search for";
            
        }
        if (counter == 12)
        {
			bWords[12] = "<color=#ff0000ff><b>escape</b></color>";
            word1 = "alarming";
            word2 = "avoidance";
            word3 = "leave";
            word4 = "dissapearance";
            
        }
		if (counter == 13) {
			gcMan.gameStart = false;
			gcMan.gpActive = false;
			gameWin.SetActive(true);
			evidence.SetActive(true);
			evidence.GetComponent<BoxCollider2D> ().enabled = false;
			tamperingGame.SetActive (false);
			finished2 = true;
		}

        linkWords();
    }
    // Update is called once per frame
    void Update () {
    	PlayerScore.TCFinished = finished2;
    	PlayerScore.D2Done = counter;

    	p1Score = p1Score + PlayerScore.C1Score;
    	p2Score = p2Score + PlayerScore.C2Score;

		PlayerScore.P1score2 = p1Score;
		PlayerScore.P2score2 = p2Score;

        storyText.text = "The murder was " + bWords[0] + " planned. The suspect's motives are the collateral murders of their wives. It is not " + bWords[1] + " proven, yet the victim was believed to have been responsible for these murders. ";
        storyText.text += "The suspect is believed to have met his accomplice " + bWords[2] + " times to discuss and plan their revenge. On the day of the murder, the suspect left his home sometime in the afternoon. The suspect was carrying " + bWords[3] + " objects to assist him. ";
        storyText.text += "We have not yet found out where they got everything from. The suspect prepared himself, as well as the " + bWords[4] + ", and left for the gala. We believe the suspect spent at least an hour in transit. When he arrived at the gala, he " + bWords[5] + " in.";
        storyText.text += "The suspect knew the victim would be present, and searched for him. The suspect " + bWords[6] + " the victim into " + bWords[7] + " him and his accomplice. The suspect might have " + bWords[8] + " a henchman to convince the victim to come with them.";
        storyText.text += "The suspect then " + bWords[9] + " the victim in the storage area. We believe he has had previous interactions with the building. The suspects are believed to have stopped in their " + bWords[10] + " due to an unforeseen situation. The suspect attempted to " + bWords[11] + " attendees and security, but was surprised by the assigned service officers in his " + bWords[12] + ".";

		if (p2Counter <= 13) {
			float p2Chance = Random.Range (0f, 100f);
			//Debug.Log (p2Chance);
			if (p2Chance <= 60.0f) {
				p2Score -= 3.0f;
				p1Score += 3.0f;
			}
			if (p2Chance > 60.0f && p2Chance <= 85.0f) {
				p2Score += 3.0f;
				p1Score -= 3.0f;
			}
			//Debug.Log (p2Score);
			p2Counter += 1;
			//Debug.Log (p2Counter);
		}
    }
}
