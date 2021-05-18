using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip walk; //Done
    public AudioClip waterWalk; //Done
    public AudioClip unlockDoor; //Done
    public AudioClip spikeMoving; //Done
    public AudioClip waterFalling; //Done
    public AudioClip leverBeingPulled; //Done
    public AudioClip doorMovingDown; //Done
    public AudioClip chairBeingTouched; //Done

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayWalkingSound()
    {
        if(!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(walk, 1f);
        }
    }

    public void PlayWaterWalk()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(waterWalk, 1f);
        }
    }

    public void DoorMovingDown()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(doorMovingDown, 1.5f);
        }
    }

    public void PlayUnlockDoor()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(unlockDoor, 1.5f);
        }
    }

    public void PlayLeverBeingPulled()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(leverBeingPulled, 1.5f);
        }
    }

    public void PlayWaterFalling()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(waterFalling, 1f);
        }
    }

    public void PlaySpikeMoving()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(spikeMoving, .9f);
        }
    }

    public void PlayChairBeingMoved()
    {
        if (!playerAudio.isPlaying)
        {
            playerAudio.PlayOneShot(chairBeingTouched, 3f);
        }
    }
}
