using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Walk : MonoBehaviour
{
    Animator anim;
    int JumpButtonPressed = Animator.StringToHash("JumpButtonPressed");
    int FireButtonPressed = Animator.StringToHash("FireButtonPressed");
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Movement();
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", move);
            AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger(JumpButtonPressed);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.ResetTrigger(JumpButtonPressed);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                anim.SetTrigger(FireButtonPressed);
            }
            else if (Input.GetKeyUp(KeyCode.F))
            {
                anim.ResetTrigger(FireButtonPressed);
            }
        }
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(Vector2.up * 250f * Time.deltaTime);
        }
    }
}