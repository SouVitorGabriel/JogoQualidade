using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private Image imgFade;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = imgFade.GetComponent<Animator>();
    }
    public void MudaCena(string sceneName)
    {
        StartCoroutine(Fading(sceneName));
    }

    IEnumerator Fading(string sceneName)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>imgFade.color.a==1);
        SceneManager.LoadScene(sceneName);
    }
}
