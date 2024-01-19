using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameOperationController : MonoBehaviour
{
    [SerializeField]
    private GameObject soluciones1;
    [SerializeField]
    private GameObject soluciones2;
    [SerializeField]
    private GameObject soluciones3;
    [SerializeField]
    private GameObject soluciones4;
    [SerializeField]
    private GameObject soluciones5;
    [SerializeField]
    private GameObject soluciones6;
    public int currentOperation = 1;

    void Update()
    {
        OperationCases();
    }
    void OperationCases()
    {
        switch (currentOperation)
        {
            case 1:
                soluciones1.SetActive(true);
                break;
            case 2:
                soluciones1.SetActive(false);
                soluciones2.SetActive(true);
                break;
            case 3:
                soluciones2.SetActive(false);
                soluciones3.SetActive(true);
                break;
            case 4:
                soluciones3.SetActive(false);
                soluciones4.SetActive(true);
                break;
            case 5:
                soluciones4.SetActive(false);
                soluciones5.SetActive(true);
                break;
            case 6:
                soluciones5.SetActive(false);
                soluciones6.SetActive(true);
                break;
            case 7:
                soluciones6.SetActive(false); 
                break;
        }
    }
    public void IncreaseCurrentOperation()
    {
        currentOperation++;
    }
}
