using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1 : MonoBehaviour
{//skrypt na start z informacj¹
    [SerializeField] private GameObject dative;
    [SerializeField] private GameObject infoWindow;
    [SerializeField] private GameObject apple;

    private PlayerMove playerControllerScript;
    private Playerlook playerLookScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMove>();
        playerLookScript = playerControllerScript.transform.GetChild(0).GetComponent<Playerlook>(); //https://stackoverflow.com/questions/40752083/how-to-find-child-of-a-gameobject-or-the-script-attached-to-child-gameobject-via
    }

    public void CloseButton()
    {
        infoWindow.SetActive(false);
        dative.SetActive(true);
        playerControllerScript.enabled = true;
        playerLookScript.enabled = true;
        
    }
}

