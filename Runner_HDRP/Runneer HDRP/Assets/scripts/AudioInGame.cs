using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AudioInGame : MonoBehaviour
{
    public AudioSource jump;
    public AudioSource dash;
    public AudioSource grapple;
    public AudioSource running;
    public AudioSource wallRunning;
    public AudioSource doubleJumping;
    public PlayerMovement2 jumping, dashing, grappling, grounded, onwall, doubleJump;

    bool justDashed;
    bool justGrappled;
    bool justDoubleJumped;

    private void Update()
    {
        if (jumping.isJumping)
        {
            jump.Play();
        }

        if (dashing.isDashing && !justDashed)
        {
            dash.Play();
            justDashed = true;
        }

        if (!dashing.isDashing)
        {
            justDashed = false;
        }

        if(grappling.playGrappleSound && !justGrappled)
        {
            grapple.Play();
            justGrappled = true;
        }

        if (!grappling.playGrappleSound)
        {
            justGrappled = false;
        }

        if (grounded.isGrounded && !running.isPlaying)
        {
            running.Play();
        }

        //if (!grounded.isGrounded)
        //{
        //    running.Stop();        
        //}

        if (onwall.wallRunning && !wallRunning.isPlaying) 
        {
            wallRunning.Play();
        }

        if (!onwall.wallRunning)
        {
            wallRunning.Stop();
        }

        if(doubleJump.doubleJumping && !justDoubleJumped)
        {
            doubleJumping.Play();
            justDoubleJumped = true;
        }

        if (!doubleJump.doubleJumping)
        {
            justDoubleJumped = false;
        }

        

        
    }
    
}
