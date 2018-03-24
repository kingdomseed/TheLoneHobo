using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeAnimation : MonoBehaviour {

    // Special thanks to Joao_Dalvi

    Image lightImage;
    public float FadeTimer;
    void Start()
    {
        
        lightImage = GetComponent<Image>();
        lightImage.CrossFadeAlpha(0, 0, true);
        StartCoroutine(Fade(FadeTimer));
    }
    IEnumerator Fade(float FadeTime)
    {
        lightImage.CrossFadeAlpha(1, FadeTime, true);
        yield return new WaitForSeconds(FadeTime);
        lightImage.CrossFadeAlpha(0, FadeTime, true);
        yield return new WaitForSeconds(FadeTime);
        StartCoroutine(Fade(FadeTime));
    }


}
