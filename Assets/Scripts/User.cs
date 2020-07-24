using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    //[SerializeField]
    //private CharacterController _controller;

    [SerializeField]
    private Image _targetUI;

    // Start is called before the first frame update
    void Start()
    {
        /*if (_controller == null)
        {
            Debug.LogError("Character Controller is null");
           
        }*/

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_targetUI.enabled == true)
            {
                _targetUI.enabled = false;
            }
            else
            {
                _targetUI.enabled = true;
            }
        }
    }
}
