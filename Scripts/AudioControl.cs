using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    //public AudioClip[] music1 = new AudioClip[4];
    public OVRPlayerController player;
    static public GameObject[] audioSource = new GameObject[20];
    static public bool isPlay = true;
    private void Awake()
    {
        audioSource[0] = GameObject.Find("1");
        audioSource[1] = GameObject.Find("2");
        audioSource[2] = GameObject.Find("3");
        audioSource[3] = GameObject.Find("4");
        audioSource[4] = GameObject.Find("5");
        audioSource[5] = GameObject.Find("6");
        audioSource[6] = GameObject.Find("7");
        audioSource[7] = GameObject.Find("8");
        audioSource[8] = GameObject.Find("9");
        audioSource[9] = GameObject.Find("10");
        audioSource[10] = GameObject.Find("11");
        audioSource[11] = GameObject.Find("12");
        audioSource[12] = GameObject.Find("13");
        audioSource[13] = GameObject.Find("14");
        audioSource[14] = GameObject.Find("15");
        audioSource[15] = GameObject.Find("16");
        audioSource[16] = GameObject.Find("17");
        audioSource[17] = GameObject.Find("18");
        audioSource[18] = GameObject.Find("19");
        audioSource[19] = GameObject.Find("20");
    }
    void Start()
    {
        

        foreach (GameObject b in audioSource)
        {
            b.SetActive(false);
        }
    }

    void Update()
    {
        AudioPlay();
    }
    void AudioPlay()
    {
        if (isPlay)
        {
            audioSource[0].SetActive(true);
            {
                if (!audioSource[0].GetComponent<AudioSource>().isPlaying)
                {
                    audioSource[1].SetActive(true);
                    if (!audioSource[1].GetComponent<AudioSource>().isPlaying)
                    {
                        audioSource[2].SetActive(true);
                        if (!audioSource[2].GetComponent<AudioSource>().isPlaying)
                        {
                            audioSource[3].SetActive(true);
                            if (!audioSource[3].GetComponent<AudioSource>().isPlaying)
                            {
                                audioSource[4].SetActive(true);
                                isPlay = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
