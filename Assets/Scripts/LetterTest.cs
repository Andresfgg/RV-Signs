using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class LetterTest : MonoBehaviour
{
    public TMP_Text letterTest;

    // Start is called before the first frame update
    void Start()
    {
        letterTest.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            List<string> VOWELS = new List<string>{"a", "e", "i", "o", "u"};
            System.Random  rnd = new System.Random();
            int index = rnd.Next(0, VOWELS.Count);
            letterTest.text = VOWELS[index];
        }
    }
}
