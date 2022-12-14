using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer: MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text coundownText;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        coundownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
