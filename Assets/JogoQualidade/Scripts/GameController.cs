using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Tela inicial:")]

    [SerializeField]
    private InputField companyNameInput;

    [SerializeField]
    private GameObject startBox;

    [Header("Game:")]
    [SerializeField]
    private GameObject gameScreen;
    [SerializeField]
    private Text companyNameSpace;
    
    [SerializeField]
    private Text companyNameSpace2;
    // Start is called before the first frame update
    void Start()
    {
        startBox.gameObject.SetActive(true);

        gameScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameStart()
    {
        companyNameSpace.text = companyNameSpace2.text = companyNameInput.text;

        startBox.gameObject.SetActive(false);

        gameScreen.gameObject.SetActive(true);
    }
}
