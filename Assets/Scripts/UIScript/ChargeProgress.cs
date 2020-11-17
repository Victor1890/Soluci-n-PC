using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChargeProgress : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Circle;
    public float tiempo = 10f;//Cuanto tiempo dura la carga hasta el 100%
    private float Contador;
    public Text TextCharge;
    void Start()
    {
        Contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Contador <= tiempo)
        {
            Contador = Contador + Time.deltaTime;
            Circle.fillAmount = Contador / tiempo;
            TextCharge.text = (Convert.ToInt32(100 * Circle.fillAmount)).ToString() + "%";
        }

    }
}
