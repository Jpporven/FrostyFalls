using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcaStateMind : MonoBehaviour
{
    public GameObject OrcaGameobject;
    public GameObject[] OrcaStates;
    public Transform[] TargetPos;
    public Transform[] OrcaPos;
    float distance0, distance1, distance2;
    int scorevalue = 0;

    public bool orcaAwake;

    private Coroutine coroutine;

    public platformMind platform;

    // Update is called once per frame
    void Update()
    {
        if (1000 > scorevalue)
        {
            OrcaGameobject.SetActive(true);

            scorevalue = scoreMind.Score / 500;

            orcaAwake = true;

            coroutine = StartCoroutine(OrcaAwake(orcaAwake));
            
        }

        if (coroutine != null) StopCoroutine(coroutine);

        distance0 = Vector3.Distance(OrcaPos[0].position, TargetPos[0].position);
        distance1 = Vector3.Distance(OrcaPos[1].position, TargetPos[1].position);
        distance2 = Vector3.Distance(OrcaPos[2].position, TargetPos[2].position);
    }

    private IEnumerator OrcaAwake(bool awake)
    {
        yield return new WaitForSeconds(3);

        OrcaStates[0].SetActive(true);

        if (distance0 < 0.5f)
        {
            OrcaStates[0].SetActive(false);
            OrcaStates[1].SetActive(true);
            distance0 = 100;
        }
        if (distance1 < 0.5f)
        {
            OrcaStates[1].SetActive(false);
            OrcaStates[2].SetActive(true);
            distance0 = 100;
        }
        if (distance2 < 15f && distance2 > 4f)
        {
            platform.platformHealth = 0;
        }
        if (distance2 < 0.5f)
        {
            OrcaStates[2].SetActive(false);
            OrcaGameobject.SetActive(false);
            distance2 = 100;

        }

        awake = false;

    }

}