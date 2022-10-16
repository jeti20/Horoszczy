using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScroingSystem : MonoBehaviour
{
    //Skrypt updejtuje nasz wynik na ekranie
    public GameObject scoreText;
    public static int theScore;
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "NITRO: " + theScore;
        if (theScore == 20)
        {
            SceneManager.LoadScene(3);
        }       
    }
}