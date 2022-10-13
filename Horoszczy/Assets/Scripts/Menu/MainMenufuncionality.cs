using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenufuncionality : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject loadText;
    public GameObject loadingBar;
    


    public void StartGameButton()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        loadText.SetActive(true);
        loadingBar.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
        Debug.Log("XD");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

}
