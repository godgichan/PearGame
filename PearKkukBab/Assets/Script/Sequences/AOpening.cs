using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class AOpening : MonoBehaviour
{
    public GameObject ThePlyer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        ThePlyer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer() {
        yield return new WaitForSeconds(1f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "으... 머리 아파 \n 여기가 어디지 ?";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        ThePlyer.GetComponent<FirstPersonController>().enabled = true;
    }
}
