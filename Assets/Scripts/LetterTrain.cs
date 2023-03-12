using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class LetterTrain : MonoBehaviour
{

    public TMP_Text letterTrain;

    // Start is called before the first frame update
    void Start()
    {
        letterTrain.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            List<string> VOWELS = new List<string>{"a", "e", "i", "o", "u"};
            System.Random  rnd = new System.Random();
            int index = rnd.Next(0, VOWELS.Count);
            letterTrain.text = VOWELS[index];
        }
    }
}
