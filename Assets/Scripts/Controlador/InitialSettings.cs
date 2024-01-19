using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSettings : MonoBehaviour
{
    [SerializeField]
    private Animator clock;
    [SerializeField]
    private GameObject gameUI;
    [SerializeField]
    private GameObject winUI;
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
    [SerializeField]
    private GameObject solucionesEmpty;
    void Awake()
    {
        clock.GetComponent<Animator>().speed = 0;
        gameUI.SetActive(false);
        winUI.SetActive(false);
        soluciones1.SetActive(false);
        soluciones2.SetActive(false);
        soluciones3.SetActive(false);
        soluciones4.SetActive(false);
        soluciones5.SetActive(false);
        soluciones6.SetActive(false);
        solucionesEmpty.SetActive(false);
    }
}
