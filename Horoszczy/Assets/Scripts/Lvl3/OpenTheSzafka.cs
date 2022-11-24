using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheSzafka : MonoBehaviour
{
    bool _isOnTrigger = false;
    GameObject _zawias;
    Animator _animator;

    private void Update()
    {
        if (_isOnTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _zawias.GetComponent<Animator>().Play("G³ównyzawias");
            }
        }

    }
}
