using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note1Trigger : MonoBehaviour
{
    [SerializeField] GameObject _actionKey;
    [SerializeField] GameObject _note1;
    [SerializeField] GameObject _dative;
    [SerializeField] GameObject _apple;
    bool _isOnTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        _actionKey.SetActive(true);
        _dative.SetActive(false);
        _actionKey.GetComponent<TextMeshProUGUI>().text = "Press [E] to read";
        _isOnTrigger = true;
    }

    private void Update()
    {
        if (_isOnTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _note1.SetActive(true);
                _actionKey.SetActive(false);
                Cursor.visible = true;
                _apple.SetActive(true);                
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        _actionKey.SetActive(false);
        _dative.SetActive(true);
        _isOnTrigger = false;
    }

    public void CloseButton()
    {
        _note1.SetActive(false);
        _dative.SetActive(true);
    }

}
