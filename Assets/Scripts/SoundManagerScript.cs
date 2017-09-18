using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {


    public AudioSource musicSource;
    public static SoundManagerScript instanceSM = null;


    // Use this for initialization
    void Awake()
    {
    }



    // Update is called once per frame
    void Update()
    {
        if (!(GetComponent<AudioSource>().isPlaying))
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            //Debug.log("Something is wrong with Music.");
        }
    }
   
}
