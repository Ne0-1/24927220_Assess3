using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudent_movement : MonoBehaviour
{
    public Animator anim;
    public GameObject PacStudent;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        PacStudent.transform.position = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Walk_east", true);
        PacStudent.transform.position = Vector2.Lerp(PacStudent.transform.position, new Vector2(0,1), Time.deltaTime);

    }
}
