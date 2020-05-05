using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("SampleScene");
    }
}
