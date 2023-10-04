using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudent_movement : MonoBehaviour
{
    public Animator anim;
    public GameObject PacStudent;
    private float speed = 3;

    //Audio:
    AudioSource step;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        PacStudent.transform.position = new Vector2(-15.5f,2.5f);

        step = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        anim.SetBool("West", false);
        anim.SetBool("East", false);
        anim.SetBool("North", false);
        anim.SetBool("South", false);



        if (PacStudent.transform.position.x <= -15.5f && PacStudent.transform.position.y == 2.5f){
            anim.SetBool("West", true);
            PacStudent.transform.position = Vector2.MoveTowards(PacStudent.transform.position, new Vector2(-20.5f,2.5f), Time.deltaTime*speed);
            if (!step.isPlaying){
                step.Play(0);
            }
        }
        if (PacStudent.transform.position.x == -20.5f && PacStudent.transform.position.y <= 6.5f){
            anim.SetBool("North", true);
            PacStudent.transform.position = Vector2.MoveTowards(PacStudent.transform.position, new Vector2(-20.5f,6.5f), Time.deltaTime*speed);
            if (!step.isPlaying){
                step.Play(0);
            }
        }
        if (PacStudent.transform.position.x <= -15.5f && PacStudent.transform.position.y == 6.5f){
            anim.SetBool("East", true);
            PacStudent.transform.position = Vector2.MoveTowards(PacStudent.transform.position, new Vector2(-15.5f,6.5f), Time.deltaTime*speed);
            if (!step.isPlaying){
                step.Play(0);
            }
        }
        if (PacStudent.transform.position.x == -15.5f && PacStudent.transform.position.y >= 2.5f){
            anim.SetBool("South", true);
            PacStudent.transform.position = Vector2.MoveTowards(PacStudent.transform.position, new Vector2(-15.5f,2.5f), Time.deltaTime*speed);
            if (!step.isPlaying){
                step.Play(0);
            }
        }
        


    }
}
