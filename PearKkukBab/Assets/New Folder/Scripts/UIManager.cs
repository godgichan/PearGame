using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    // Start is called before the f
    IEnumerator OnClickStartBtn()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SceneLoader");
    }
 
    public void wait()
    {
        StartCoroutine("OnClickStartBtn");
    }
 
}
