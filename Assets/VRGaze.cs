using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    bool gaze = false;
    float timer = 0f;
    public void GazeOn()
    {
        gaze = true;
    }

    public void GazeOff()
    {
        gaze = false;
        timer = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gaze)
        {
            timer += Time.deltaTime;
            if (timer >= 1f)
            {
                timer = 0f;
                gaze = false;
                gameObject.GetComponent<Button>().onClick.Invoke();
            }
        }
    }
}
