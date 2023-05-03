using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;
    [SerializeField] Text countDownText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        /*if (currentTime <=0)
        {
            currentTime = 0;

        }*/
    }
}
