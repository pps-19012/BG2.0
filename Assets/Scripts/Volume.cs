using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    Slider slider
    {
        get { return GetComponent<Slider>(); }
    }

    public AudioMixer mixer;
    public string volumeName;

    public void UpdateValueOnChange(float value)
    {
        mixer.SetFloat(volumeName, Mathf.Log(value) * 20f);
    }
}
