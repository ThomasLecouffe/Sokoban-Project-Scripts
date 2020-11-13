using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayCanvas : MonoBehaviour
{

    private CanvasGroup rect;
    private Button continueButton;
    public float timeToAlpha = 3.0f;



    GraphicRaycaster graphicRaycaster;

    // Start is called before the first frame update
    void Start()
    {
        graphicRaycaster = gameObject.GetComponent<GraphicRaycaster>();
        graphicRaycaster.enabled = false;
        rect = GetComponent<CanvasGroup>();

        //continueButton = GameObject.Find("Continue").GetComponent<Button>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void displayCanvas(int alpha)
    {
        graphicRaycaster.enabled = true;
        LeanTween.alphaCanvas(rect, alpha, timeToAlpha);

    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
