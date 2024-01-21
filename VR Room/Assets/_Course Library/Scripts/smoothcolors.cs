using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothcolors : MonoBehaviour
{
    public Color starColor = Color.red;
    public Color endColor = Color.blue;
    public float duration = 1f;
    private bool islerping = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(colorLerp());
    }

    // Update is called once per frame
    void Update()
    {
        /*
         
         */
    }
    IEnumerator colorLerp()
    {
        while (true)
        {
            islerping = !islerping;
            float time = 0;
            while(time < duration)
            {
                time += Time.deltaTime;
                float t = time / duration;
                if (islerping)
                {
                    GetComponent<Renderer>().material.color = Color.Lerp(starColor, endColor, t);
                }
                else
                {
                    GetComponent<Renderer>().material.color = Color.Lerp(endColor, starColor, t);
                }
                yield return null;
            }
        }
    }
}
