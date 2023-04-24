using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
        Debug.Log("Level Complete");
        var audios = GetComponent<AudioSource>();
        audios.Play();
    }
}
