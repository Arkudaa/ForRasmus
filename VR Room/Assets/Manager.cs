using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int wallet;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 30;
    }

    // Update is called once per frame
   public void Increasewallet()
    {
        wallet++;
    }

    public void Update()
    {
        seconds -=Time.deltaTime;
        if (seconds <= 0.01)
        {
            Time.timeScale = 0;
        }


    }
}
