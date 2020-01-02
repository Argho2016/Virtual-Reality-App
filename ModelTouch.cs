using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ModelTouch : MonoBehaviour {

    public GameObject videoPlayerPlane;
    private VideoPlayer videoPlayer;
    private Animator animator;
    private Animator videoAnimator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        videoAnimator = videoPlayerPlane.GetComponent<Animator>(); 
        videoPlayer = videoPlayerPlane.GetComponent<VideoPlayer>();
    }
	


    void OnMouseDown()
    {
        animator.SetBool("Scale",true);
        Invoke("PlayVideo",.5f);       
    }

    void PlayVideo()
    {
        videoPlayer.Play();
        videoAnimator.SetBool("Scale", true);
    }
}
