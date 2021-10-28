using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOperations : MonoBehaviour
{
    [SerializeField]
    private GameObject swingLeftObject;
    [SerializeField]
    private GameObject swingRightObject;

    public void enableSwingScript()
    {
        swingLeftObject.GetComponent<SwingObject>().enabled = true;
        swingRightObject.GetComponent<SwingObject>().enabled = true;
    }
}
