using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    GameObject mainCamera;
    GameObject selectedGo;
    GameObject lastSelectedGo;
    public float timeToDestruction;//Tiempo que hay que mirar al target para que se destruya
    float time;//Tiempo acumulado mirando al target
    private void Start()
    {
        mainCamera = Camera.main.gameObject;
    }

    void Update () {
        selectedGo = GetSelectedGo();
        if (selectedGo == null)
        {
            time = 0;
            lastSelectedGo = selectedGo;
        }
        else
        {
            if (selectedGo == lastSelectedGo)
            {
                //Estoy mirando a lo mismo del frame anterior
                time += Time.deltaTime;
                selectedGo.GetComponent<CanvasAsteriod>().SetSliderValue(time);
                if (time >= timeToDestruction)
                {
                    //Destruyo el target
                    selectedGo.GetComponent<Asteroide>().Destroy();
                    time = 0;
                }
            } else
            {
                time = 0;
                lastSelectedGo = selectedGo;
            }
        }
	}
    private GameObject GetSelectedGo()
    {
        GameObject selectedGo = null;
        Ray raycast = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        RaycastHit raycastHit;
        if (Physics.Raycast(raycast, out raycastHit))
        {
            selectedGo = raycastHit.transform.gameObject;
        }
        return selectedGo;
    }
}
