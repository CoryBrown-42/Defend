using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsEnd : MonoBehaviour {

    public IEnumerator End;

    public int GoToNextSceneTime = 0;

    // Use this for initialization
    void Start () {
        End = CreditsEnding();
        StartCoroutine(End);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 4;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void EndOfCredits()
    {
        
    }
    public IEnumerator CreditsEnding()
    {
        yield return new WaitForSeconds(GoToNextSceneTime);
        SceneManager.LoadScene("MobileMenu");

    }
}
