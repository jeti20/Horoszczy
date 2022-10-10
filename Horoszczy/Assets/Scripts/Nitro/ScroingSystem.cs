using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScroingSystem : MonoBehaviour
{
//Skrypt updejtuje nasz wynik na ekranie
    public GameObject scoreText;
    public static int theScore;
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "NITRO: " + theScore;
       
    }
}
