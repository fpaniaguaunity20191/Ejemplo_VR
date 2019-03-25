using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasAsteriod : MonoBehaviour {
    public Slider slider;
	void Update () {
        transform.LookAt(Camera.main.transform);
	}
    public void SetSliderValue(float value)
    {
        slider.value = value;
    }
}
