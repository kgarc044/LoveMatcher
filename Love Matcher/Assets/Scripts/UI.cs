using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI: MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    int coupleTotal = 0;

    [SerializeField] Text coundownText;
    [SerializeField] Text coupleCounter;

    public int CoupleTotal
    {
        set
        {
            coupleTotal = coupleTotal + value;
            CalculateTotalCouples();
        }
    }
    

    void Start()
    {
        currentTime = startingTime;
        coupleTotal = 0;
        CalculateTotalCouples();
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

    public void CalculateTotalCouples()
    {
        coupleCounter.text = coupleTotal.ToString();
    }
}
