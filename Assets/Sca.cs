using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Hover()
    {
        gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 1f);
    }

    public void HoverOver()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
