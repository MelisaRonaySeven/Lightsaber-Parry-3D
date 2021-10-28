using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectSaberCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject collidedText;
    [SerializeField]
    private GameObject resimulatePanel;
    [SerializeField]
    private ParticleSystem pSystem;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RightSaber" || collision.gameObject.tag == "LeftSaber")
        {
            pSystem.transform.position = collision.GetContact(0).point;
            pSystem.GetComponent<ParticleSystem>().Play();
            collision.gameObject.GetComponent<SwingObject>().enabled = false;
            collidedText.SetActive(true);
            StartCoroutine(simulationFinishedCoroutine());
        }
    }

    private IEnumerator simulationFinishedCoroutine()
    {
        yield return new WaitForSeconds(5);
        pSystem.GetComponent<ParticleSystem>().Stop();
        resimulatePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
    }
}
