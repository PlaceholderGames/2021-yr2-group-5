using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingManager : MonoBehaviour
{
    public PostProcessVolume _volume;

    public BarCode _Bar;

    private Vignette _Vignette;

    void Start()
    {
        _volume.profile.TryGetSettings(out _Vignette);
        _Vignette.intensity.value = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (_Bar.getTimeLeft() > _Bar.getMaxTime() / 3 && _Vignette.intensity.value<0.45)
        {
            _Vignette.intensity.value += 0.05f;//Mathf.Lerp(_Vignette.intensity.value, 1, (_Bar.getTimeLeft() /*/ (_Bar.getMaxTime()*2*/));
        }
        else if (_Bar.getTimeLeft() > (_Bar.getMaxTime() * 0.75f) && _Vignette.intensity.value < 0.6)
        {
            _Vignette.intensity.value += 0.05f;
        }
    }
}
