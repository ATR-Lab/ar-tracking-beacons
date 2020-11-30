using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    [SerializeField]
    private GameObject _targetUI, _compass;

    void Start()
    {
        //Hides cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        //Unhides cursor
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        //Toggles UI visibility
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_targetUI.activeInHierarchy == true)
            {
                _targetUI.SetActive(false);
                _compass.SetActive(false);
            }
            else
            {
                _targetUI.SetActive(true);
                _compass.SetActive(true);
            }
        }
    }
}
