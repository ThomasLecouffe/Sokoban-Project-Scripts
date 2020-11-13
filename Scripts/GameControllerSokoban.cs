using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class GameControllerSokoban : MonoBehaviour
{
    public Tilemap crates;
    public Tilemap cratesSolution;

    private TileBase[] spots;
    private TileBase[] cratesLocation;
    public GameObject endingCanvas;

    private DisplayCanvas displayCanvas;
    private bool isPaused = true;

    private float timeSpent = 0;
    private TextMeshProUGUI WinMessageText;

    public GameObject WinMessage;
    public GameObject ContinueButton;


    // Start is called before the first frame update
    void Start()
    {
        WinMessageText = WinMessage.GetComponent<TextMeshProUGUI>();

        displayCanvas = endingCanvas.GetComponent<DisplayCanvas>();
    }

    private void Update()
    {
        spots = cratesSolution.GetTilesBlock(cratesSolution.cellBounds);
        timeSpent += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                isPaused = true;
                displayCanvas.displayCanvas(1);
            }
            else { 
                isPaused = false;
                displayCanvas.displayCanvas(0);
            }
            
        }
    }

    public void checkWin()
    {
        cratesLocation = crates.GetTilesBlock(cratesSolution.cellBounds);

        if (cratesLocation.SequenceEqual(spots))
        {
            WinMessageText.text = "You won ! " + ((int)timeSpent).ToString() + " seconds";
            WinMessage.SetActive(true);
            ContinueButton.SetActive(false);
            displayCanvas.displayCanvas(1);
        }
    }

}
