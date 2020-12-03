using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarCode : MonoBehaviour
{
    Image timerBar;
    float maxTime=50f;
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
            SceneManager.LoadScene(3);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public float getTimeLeft()
    {
        return timeLeft;
    }

    public void setTimeLeft(float num)
    {
        timeLeft = num;
    }
}
