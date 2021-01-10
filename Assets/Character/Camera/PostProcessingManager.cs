using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingManager : MonoBehaviour
{
    public PostProcessVolume _volume;
    public PotionManager _potion;
    public BarCode _Bar;

    private Vignette _Vignette;
    private ChromaticAberration _Chrom;
    private LensDistortion _Lens;

    void Start()
    {
       
        _volume.profile.TryGetSettings(out _Vignette);
        _volume.profile.TryGetSettings(out _Chrom);
        _volume.profile.TryGetSettings(out _Lens);
        _Lens.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chrom.intensity.value = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (_Bar.getTimeLeft() > _Bar.getMaxTime() / 3 && _Vignette.intensity.value<0.3)
        {
            _Vignette.intensity.value += 0.005f;//Mathf.Lerp(_Vignette.intensity.value, 1, (_Bar.getTimeLeft() /*/ (_Bar.getMaxTime()*2*/));
        }
        else if (_Bar.getTimeLeft() > (_Bar.getMaxTime() * 0.75f) && _Vignette.intensity.value < 0.35)
        {
            _Vignette.intensity.value += 0.005f;
        }
        _Chrom.intensity.value = (0.33f * _potion.getPotionsUsed());
        _Lens.intensity.value = (16.66f * _potion.getPotionsUsed());
    }
}
