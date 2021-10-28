using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private Slider mSlider;
    private float zLimit = 90f;

    void Start()
    {
        mSlider.onValueChanged.AddListener(delegate
        {
            rotateObject();
        });
    }

    private void rotateObject()
    {
        if(transform.tag == "LeftSaber")
        {
            transform.localEulerAngles = new Vector3(0, -90, -mSlider.value * zLimit);
        }
        else if(transform.tag == "RightSaber")
        {
            transform.localEulerAngles = new Vector3(0, -90, mSlider.value * zLimit);
        }

    }
}
