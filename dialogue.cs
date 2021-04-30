using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogue : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float TypingSpeed;

    public GameObject continueButton;
    public Animator textDisplayAnim;

    void Start() {

        StartCoroutine(Type());

    }

    void Update() {


        if (sentences.Length < 3) {
            continueButton.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.C))
            {
                NextSentence();
            }

        if (textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);

        }

    }

    IEnumerator Type() {

        // loop equal to amount of letters in text
        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(TypingSpeed);
        }


    }

   


public void NextSentence(){
        textDisplayAnim.SetTrigger("Change"); 
        continueButton.SetActive(false);

        if (index < sentences.Length - 1){
                index++;
                textDisplay.text = "";
                StartCoroutine(Type());
        } else {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }


    }
}
   
