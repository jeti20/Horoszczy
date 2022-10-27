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

    public GameObject fadeOut;
    public GameObject loadText;
    public GameObject loadingBar;
    public GameObject player;

    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "NITRO: " + theScore;
        if (theScore == 1)
        {
            StartCoroutine(StartGame());
            
        }       

    }

    IEnumerator StartGame()
    {
        player.GetComponent<PlayerController>().enabled = false;
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        loadText.SetActive(true);
        loadingBar.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
        Debug.Log("Moving to lvl3");
    }
}