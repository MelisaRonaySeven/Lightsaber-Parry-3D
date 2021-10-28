using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwingObject : MonoBehaviour
{
    [SerializeField]
    private GameObject resimulatePanel;
    private int yLimit = 90;
    private Vector3 baseRotation;

    private void Start()
    {
        getCurrentRotation();
    }

    private void getCurrentRotation()
    {
        baseRotation = transform.localEulerAngles;
        baseRotation.y = -(360 - baseRotation.y);
        baseRotation.z = -(360 - baseRotation.z);
    }

    private void Update()
    {
        if(baseRotation.y < yLimit)
        {
            baseRotation.y++;
            transform.localEulerAngles = new Vector3(baseRotation.x, baseRotation.y, baseRotation.z);
        }
        else
        {
            StartCoroutine(simulationFinishedCoroutine());
        }
        
    }

    private IEnumerator simulationFinishedCoroutine()
    {
        resimulatePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
    }
}
