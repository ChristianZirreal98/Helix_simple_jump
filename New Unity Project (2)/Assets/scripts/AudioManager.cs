using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] GameObject muted, Notmuted;
    bool is_muted;

    private void Start()
    {
        is_muted = PlayerPrefs.GetInt("mute") == 1;
    }

    private void Update()
    {
        
        if( is_muted == false)
        {
            muted.SetActive(false);
            Notmuted.SetActive(true);
        }

        else
        {
            muted.SetActive(true);
            Notmuted.SetActive(false);
        }


    }

    public void Presed()
    {
        is_muted = !is_muted;

        AudioListener.pause = is_muted;

        PlayerPrefs.SetInt("mute", is_muted ? 1 : 0);
    }
}
