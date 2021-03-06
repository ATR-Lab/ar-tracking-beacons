﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITracking : MonoBehaviour
{
    [SerializeField]
    private GameObject _targetUI, _needle, _sphere, _user, _target1, _target2;
    [SerializeField]
    private float radians;
    [SerializeField]
    private Camera _camera;

    private GameObject _trackedObject;
  

    /*      _trackedObject = object being tracked
     *      _targetUI = UI targeting box
     *      _needle = UI compass needle 
     */

   

    private void Start()
    {

        //_camera = transform.Find("Main Camera").GetComponent<Camera>();
        _trackedObject = _target1;
        Debug.Log("_trackedObject = " + _trackedObject);
        Compass(_trackedObject);


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (_trackedObject == _target1)
            {
                _trackedObject = _target2;
            }
            else
            {
                _trackedObject = _target1;
            }
            Debug.Log("_trackedObject = " + _trackedObject);
        }

        if (_trackedObject != null)
        {
            Compass(_trackedObject);
            TargetBox();
        }
      
    }


    public void TargetBox()
    {
        Vector3 screenPos = _camera.WorldToScreenPoint(_trackedObject.transform.position);
        _targetUI.transform.position = screenPos;
    
    }

    public void Compass(GameObject _target)
    {
        
        //Compass code
        Vector3 newDirection = Vector3.RotateTowards(_needle.transform.position, _target.transform.position - transform.position, radians, radians);
        Quaternion newAngle = Quaternion.Euler(newDirection.x, newDirection.y, newDirection.z);
        _needle.transform.rotation = (newAngle);

        //Debug rays
        float distance = Vector3.Distance(_user.transform.position, _target.transform.position);
        Debug.DrawRay(_user.transform.position, newDirection * (distance / 4), Color.red);
        Debug.DrawRay(_needle.transform.position, newDirection * (distance / 4), Color.green);
    }


}
