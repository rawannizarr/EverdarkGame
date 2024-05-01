using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTimer : MonoBehaviour
{
    public float sceneDurationInMinutes = 2f;
    public GameObject messagePanel;
    private void Start()
    {
        StartCoroutine(WaitForSceneDuration());

    }
    private IEnumerator WaitForSceneDuration()
    {
        yield return new WaitForSeconds(sceneDurationInMinutes * 60f);

        messagePanel.SetActive(true);
    }
}
