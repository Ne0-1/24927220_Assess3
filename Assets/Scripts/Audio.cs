using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource Ghost_normal_state;
    // Start is called before the first frame update
    void Start()
    {
        intro.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!intro.isPlaying && !Ghost_normal_state.isPlaying){
            Ghost_normal_state.Play(0);
        }
    }
}
