using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreSpawnOverTime : MonoBehaviour {


    public GameObject SpawnSet2;
    public GameObject SpawnSet3;
    public GameObject SpawnSet4;
    public GameObject SpawnSet5;

    public int round2 = 10;
    public int round3 = 20;
    public int round4 = 60;
    public int round5 = 120;

    public IEnumerator next1;
    public IEnumerator next2;
    public IEnumerator next3;
    public IEnumerator next4;

    // Use this for initialization
    void Start () {
        SpawnSet2.SetActive(false);
        SpawnSet3.SetActive(false);
        SpawnSet4.SetActive(false);
        SpawnSet5.SetActive(false);

        

        next1 = RoundOne();
        next2 = RoundTwo();
        next3 = RoundThree();
        next4 = RoundFour();


        StartCoroutine(next1);
        StartCoroutine(next2);
        StartCoroutine(next3);
        StartCoroutine(next4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerator RoundOne()
    {
        yield return new WaitForSeconds(round2);
        SpawnSet2.SetActive(true);

    }
    public IEnumerator RoundTwo()
    {
        yield return new WaitForSeconds(round3);
        SpawnSet3.SetActive(true);

    }
    public IEnumerator RoundThree()
    {
        yield return new WaitForSeconds(round4);
        SpawnSet4.SetActive(true);

    }
    public IEnumerator RoundFour()
    {
        yield return new WaitForSeconds(round5);
        SpawnSet5.SetActive(true);

    }
}
