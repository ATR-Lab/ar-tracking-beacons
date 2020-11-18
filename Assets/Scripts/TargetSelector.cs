using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelector : MonoBehaviour
{

    [SerializeField]
    private GameObject _target1, _target2;

    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        targetObject = _target1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (targetObject = _target1)
            {
                targetObject = _target2;
            }
            else targetObject = _target1;
        }
    }
}
