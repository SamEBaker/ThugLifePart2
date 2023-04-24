using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wnd : MonoBehaviour
{
    [SerializeField] AudioClip[] _clips;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var clip = _clips[UnityEngine.Random.Range(0, _clips.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
        else
        {
            Debug.Log("Collision too slow");
        }
    }
}
