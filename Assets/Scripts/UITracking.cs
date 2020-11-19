using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITracking : MonoBehaviour
{
    [SerializeField]
    private GameObject _targetUI, _needle, _user, _target1, _target2;
    [SerializeField]
    private Camera _camera;

    private GameObject _trackedObject;
  

    /*      _trackedObject = object being tracked
     *      _targetUI = UI targeting box
     *      _needle = UI compass needle 
     */

   

    private void Start()
    {

        _camera = transform.Find("Main Camera").GetComponent<Camera>();
        _trackedObject = _target1;



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
        }

        //Targeting box code
        Vector3 screenPos = _camera.WorldToScreenPoint(_trackedObject.transform.position);
        _targetUI.transform.position = screenPos;

        Compass(_trackedObject);
        

    }

    void Compass(GameObject _target)
    {

        Vector3 newDirection = Vector3.RotateTowards(_user.transform.position, _target.transform.position/* - transform.position*/, 4, 4);
        float distance = Vector3.Distance(_user.transform.position, _target.transform.position);
        Debug.DrawRay(_user.transform.position, newDirection * (distance/4), Color.red);
        Quaternion newAngle = Quaternion.Euler(newDirection.x, newDirection.y, newDirection.z);
        _needle.transform.rotation = newAngle;
    }


}
