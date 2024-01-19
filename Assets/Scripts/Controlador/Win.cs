using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    private GameObject winUI;
    [SerializeField]
    private GameObject clock;
    [SerializeField]
    private GameObject gameUI;
    
    void Update()
    {
        if (GetComponent<GameOperationController>().currentOperation == 7){
            winUI.SetActive(true);
            clock.SetActive(false);
            gameUI.SetActive(false);
        }
    }
}
