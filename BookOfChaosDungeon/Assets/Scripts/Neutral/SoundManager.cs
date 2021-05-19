using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip walk; 
    public AudioClip waterWalk; 
    public AudioClip unlockDoor; 
    public AudioClip spikeMoving; 
    public AudioClip waterFalling; 
    public AudioClip leverBeingPulled; 
    public AudioClip doorMovingDown; 
    public AudioClip chairBeingTouched;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>(); //Connects audio source to this script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * Sound of footsteps
     */
    public void PlayWalkingSound()
    {
        if(!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(walk, 1f);
        }
    }

    /**
     * Sound of someone walking through water
     */
    public void PlayWaterWalk()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(waterWalk, 1f);
        }
    }

    /**
     * Sound of the door moving down into the ground
     */
    public void DoorMovingDown()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(doorMovingDown, 1.5f);
        }
    }

    /**
     * Sound of the door lock being unlocked
     */
    public void PlayUnlockDoor()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(unlockDoor, 1.5f);
        }
    }

    /**
     * Sound of the levers being pulled
     */
    public void PlayLeverBeingPulled()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(leverBeingPulled, 1.5f);
        }
    }

    /**
     * Sound water hitting water
     */
    public void PlayWaterFalling()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(waterFalling, 1f);
        }
    }

    /**
     * Sound of the spike panel moving
     */
    public void PlaySpikeMoving()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(spikeMoving, .9f);
        }
    }

    /**
     * Sound of the chair being moved
     */
    public void PlayChairBeingMoved()
    {
        if (!playerAudio.isPlaying) //If the sound isn't playing
        {
            playerAudio.PlayOneShot(chairBeingTouched, 6f);
        }
    }
}
