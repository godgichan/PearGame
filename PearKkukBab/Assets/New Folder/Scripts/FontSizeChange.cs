using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class FontSizeChange : MonoBehaviour
{
    public Button m_btn;
    public Text m_text;

    public void OnClickBtn()
    {
        m_text.fontSize = 70;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_btn = GetComponent<Button>();
        m_btn.onClick.AddListener(OnClickBtn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
