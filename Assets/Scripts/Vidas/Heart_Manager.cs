using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Manager : MonoBehaviour
{
    private Lives_Counter Vidas;
    [SerializeField]
    private GameObject Heart_1;
    [SerializeField]
    private GameObject Heart_2;
    [SerializeField]
    private GameObject Heart_3;

    void Start()
    {
        Vidas = GetComponent<Lives_Counter>();
    }
    void Update()
    {
        if (Vidas.Vidas == 2)
        {
            Heart_3.SetActive(false);
        }
        else if (Vidas.Vidas == 1)
        {
            Heart_2.SetActive(false);
        }
        else if (Vidas.Vidas == 0)
        {
            Heart_1.SetActive(false);
        }
    }
}
