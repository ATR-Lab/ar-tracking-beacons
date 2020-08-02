using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITracking : MonoBehaviour
{
    [SerializeField]
    private GameObject _trackedObject, _targetUI, _needle;
    [SerializeField]
    private Camera _camera;

    private void Start()
    {

        _camera = transform.Find("Main Camera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 screenPos = _camera.WorldToScreenPoint(_trackedObject.transform.position);
        _targetUI.transform.position = screenPos;

        Vector3 newDirection = Vector3.RotateTowards(_needle.transform.position, _trackedObject.transform.position - transform.position, 2, 2);
        Debug.DrawRay(_needle.transform.position, newDirection, Color.red);
        _needle.transform.rotation = Quaternion.LookRotation(newDirection);

    }


}
