using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

	public IEnumerator Play;
	public IEnumerator Exit;

	public int GoToNextSceneTime = 0;

	// Use this for initialization
	void Start()
	{
		Play = PressPlay();
		Exit = PressExit();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void PressP()
	{
		StartCoroutine(Play);
	}
	public void PressE()
	{
		StartCoroutine(Exit);
	}
    public void PressC()
    {
       SceneManager.LoadScene("credits");
    }

    public IEnumerator PressPlay()
	{
		yield return new WaitForSeconds(GoToNextSceneTime);
		SceneManager.LoadScene("EndlessRun");

	}

	public IEnumerator PressExit()
	{
		Application.Quit();
		yield return new WaitForSeconds(1);
	}
}
