using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarCode : MonoBehaviour
{
    Image timerBar;
    public float maxTime=5f;
    float timeLeft;
  

    // Start is called before the first frame update
    void Start()
    {
    timerBar = GetComponent<Image>();
    timeLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft < maxTime)
        {
            timeLeft += Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
    else
        {
            Time.timeScale = 0;
        }
    }
}
