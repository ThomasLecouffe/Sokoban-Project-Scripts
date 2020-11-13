using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCamera : MonoBehaviour
{

    public Slider widthSlider;




    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCameraValue()
    {
        float x = widthSlider.value * 0.58f + 0.684f;
        float y = widthSlider.value * 1.69f + 0.709f;
        gameObject.GetComponent<Camera>().orthographicSize = widthSlider.value * 1.81f + 1.4f;
        gameObject.transform.position = new Vector3(x, y, -10);
    }
}
