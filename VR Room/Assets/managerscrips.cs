using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerscrips : MonoBehaviour
{
    public int score;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        seconds = 30;
    }
    public void Increasescore()
    {
        score++;
    }
    // Update is called once per frame
    void Update()
    {
        seconds-=Time.deltaTime;
        if (seconds <= 0.01)
        {
            Time.timeScale = 0;
        }
    }
}
