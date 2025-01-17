using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public BeautyBar beauty;
    public GameObject SleepBuild1;
    public GameObject SleepBuild2;
    public GameObject SleepBuild3;
    public GameObject HeatBuild1;
    public GameObject HeatBuild2;
    public GameObject HeatBuild3;
    public GameObject LightBuild1;
    public GameObject LightBuild2;
    public GameObject LightBuild3;
    public GameObject CoralBuild1;
    public GameObject CoralBuild2;
    public GameObject CoralBuild3;

    private bool hasSleepSource;
    private bool hasHeatSource;
    private bool hasLightSource;
    private bool hasCoral;

    private float waitTime1 = 0.5f;
    private float waitTime2 = 0.5f;
    private float waitTime3 = 0.5f;
    private float waitTime4 = 0.5f;

    private int sleepSources;
    private int heatSources;
    private int lightSources;
    private int corals;

    private GameObject toDestroy;
    public AudioSource buildSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasSleepSource)
        {
            waitTime1 -= Time.deltaTime;

            if(waitTime1 <= 0)
            {
                Destroy(toDestroy);

                if(sleepSources == 1)
                {                    
                    beauty.sleepSource = true;
                    beauty.objectA = true;
                    buildSound.Play();
                    SleepBuild1.SetActive(true);
                    toDestroy = null;
                    waitTime1 = 0.5f;
                    hasSleepSource = false;
                }
                
                if(sleepSources == 2)
                {
                    buildSound.Play();
                    SleepBuild2.SetActive(true);
                    toDestroy = null;
                    waitTime1 = 0.5f;
                    hasSleepSource = false;
                }

                if(sleepSources == 3)
                {
                    buildSound.Play();
                    SleepBuild3.SetActive(true);
                    toDestroy = null;
                    waitTime1 = 0.5f;
                    hasSleepSource = false;
                }
            }
        }

        if (hasHeatSource)
        {
            waitTime2 -= Time.deltaTime;

            if (waitTime2 <= 0)
            {
                Destroy(toDestroy);

                if (heatSources == 1)
                {
                    buildSound.Play();
                    HeatBuild1.SetActive(true);
                    toDestroy = null;
                    beauty.heatSource = true;
                    beauty.objectB = true;
                    waitTime2 = 0.5f;
                    hasHeatSource = false;
                }

                if (heatSources == 2)
                {
                    buildSound.Play();
                    HeatBuild2.SetActive(true);
                    toDestroy = null;
                    waitTime2 = 0.5f;
                    hasHeatSource = false;
                }

                if (heatSources == 3)
                {
                    buildSound.Play();
                    HeatBuild3.SetActive(true);
                    toDestroy = null;
                    waitTime2 = 0.5f;
                    hasHeatSource = false;
                }
            }
        }

        if (hasLightSource)
        {
            waitTime3 -= Time.deltaTime;

            if (waitTime3 <= 0)
            {
                Destroy(toDestroy);

                if (lightSources == 1)
                {
                    buildSound.Play();
                    LightBuild1.SetActive(true);
                    toDestroy = null;
                    beauty.lightSource = true;
                    beauty.objectC = true;
                    waitTime3 = 0.5f;
                    hasLightSource = false;
                }

                if (lightSources == 2)
                {
                    buildSound.Play();
                    LightBuild2.SetActive(true);
                    toDestroy = null;
                    waitTime3 = 0.5f;
                    hasLightSource = false;
                }

                if (lightSources == 3)
                {
                    buildSound.Play();
                    LightBuild3.SetActive(true);
                    toDestroy = null;
                    waitTime3 = 0.5f;
                    hasLightSource = false;
                }
            }
        }

        if (hasCoral)
        {
            waitTime4 -= Time.deltaTime;

            if (waitTime4 <= 0)
            {
                Destroy(toDestroy);

                if (corals == 1)
                {
                    buildSound.Play();
                    CoralBuild1.SetActive(true);
                    toDestroy = null;
                    waitTime4 = 0.5f;
                    hasCoral = false;
                }

                if (corals == 2)
                {
                    buildSound.Play();
                    CoralBuild2.SetActive(true);
                    toDestroy = null;
                    waitTime4 = 0.5f;
                    hasCoral = false;
                }

                if (corals == 3)
                {
                    buildSound.Play();
                    CoralBuild3.SetActive(true);
                    toDestroy = null;
                    waitTime4 = 0.5f;
                    hasCoral = false;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sleep Source" && sleepSources <= 2 && other.tag != "Player" && other.tag != "TransparrentFX")
        {
            Debug.LogError(other.gameObject.name);
            toDestroy = other.gameObject;
            sleepSources++;
            hasSleepSource = true;
        }

        if (other.gameObject.name == "Heat Source" && heatSources <= 2 && other.tag != "Player" && other.tag != "TransparrentFX")
        {
            Debug.LogError(other.gameObject.name);
            toDestroy = other.gameObject;
            heatSources++;
            hasHeatSource = true;
        }

        if (other.gameObject.name == "Light Source" && lightSources <= 2 && other.tag != "Player" && other.tag != "TransparrentFX")
        {
            Debug.LogError(other.gameObject.name);
            toDestroy = other.gameObject;
            lightSources++;
            hasLightSource = true;
        }

        if (other.gameObject.name == "Coral" && corals <= 2 && other.tag != "Player" && other.tag != "TransparrentFX")
        {
            Debug.LogError(other.gameObject.name);
            toDestroy = other.gameObject;
            corals++;
            hasCoral = true;
        }
    }
}
