/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformacjaButtons : MonoBehaviour
{
    public GameObject informacja1;
    public GameObject informacja2;

    public void Next()
    {
        StartCoroutine(NextButton());
    }

    IEnumerator NextButton()
    {
        informacja1.SetActive(false);
        yield return new WaitForSeconds(0.001f);
        informacja2.SetActive(true);      
    }

    public void Close()
    {
        informacja2.SetActive(false);
    }

 *//*   IEnumerator CloseButton()
    {
        informacja2.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        
    }*//*
}*/
