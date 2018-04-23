using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rythmScript : MonoBehaviour
{
    [SerializeField] private AudioSource testSource;
    [SerializeField] private AudioClip rythmClip;
    [SerializeField] private GameObject meteor;
    [SerializeField] private GameObject airplane;
    Transform airplaneTrans;
    private float bpm;
    private float lastTime, timer, dTime;
    float[] positionOfAsteroid = { 5.0f, 1.5f, -2.0f };
    // Use this for initialization
    void Start()
    {
        dTime = 0;
        lastTime = 0;
        bpm = 36.5f;
        airplaneTrans = airplane.GetComponent<Transform>();
        //  bpm = rythmClip
        //  testSource.timeSamples;
        //  rythmClip.frequency;
        //  rythmClip.ambisonic;
        //  rythmClip.samples;
        //  rythmClip.length;

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2.0f);
        if (!testSource.isPlaying)
        {
            switchToWinScreen sw = new switchToWinScreen();
            sw.onWin();
        }
    }

    void FixedUpdate()
    {
        dTime = testSource.time - lastTime;
        timer += dTime;


        if (timer >= ((60.0f / bpm)))
        {
            Vector3 meteorSpawn = new Vector3(airplaneTrans.position.x + 15.0f, positionOfAsteroid[Random.Range(0, 15) % 3], -0.15f);

            Instantiate(meteor, meteorSpawn, meteor.transform.rotation);
            timer -= (60.0f / bpm);
        }

        lastTime = testSource.time;


        StartCoroutine(wait());
    }
}
