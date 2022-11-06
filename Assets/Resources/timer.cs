using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float timee;
    float i_time;
    public int minute;
    public int second;
    float t_time = 0f;
    int g_time = 1;
    public Text tx;
    public Image ig;
    public Image ig2;
    public Image ig3;
    public Image ig4;
    bool good = false;
    // Start is called before the first frame update
    void Start()
    {
        i_time = timee = (minute * 60) + second;
    }
    public void kardeStart()
    {
        good = true;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(t_time + "t_time");
        Debug.Log(g_time + "g_time");
        Debug.Log(timee + "timee");
        if(good)
            t_time += Time.deltaTime;
        if (t_time > g_time)
        {
            g_time = (int)t_time + 1;
            t_time -= 0.2f;
            timee--;
            minute = (int)timee / 60;
            second = (int)timee % 60;
        }

        if (timee <= 0)
        {
            good = false;
        }

        ig.GetComponent<Image>().fillAmount = timee / i_time;
        ig2.GetComponent<Image>().fillAmount = 1 - (timee / i_time);
        ig3.GetComponent<Image>().fillAmount = 1 - (timee / i_time);
        ig4.GetComponent<Image>().fillAmount = 1 - (timee / i_time);
        tx.text = minute.ToString() + " : " + second.ToString();
    }
}
