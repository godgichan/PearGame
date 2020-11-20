using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnDown : MonoBehaviour
{
    public bool ButtonDown=true;
    public bool ButtonUp;
    public Text m_text;


    public void PointerDown()
    {
        ButtonDown = true;
        m_text.fontSize = 95;
    }

    public void PointerUP()
    {
        ButtonUp = true;
        m_text.fontSize = 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
