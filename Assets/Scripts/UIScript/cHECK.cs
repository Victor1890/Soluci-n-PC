using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class cHECK : MonoBehaviour
{
	public UnityEngine.UI.Image Circle;
	public float tiempo = 10f;//Cuanto tiempo dura la carga hasta el 100%
	private float Contador;
	public Text TextCharge;
	public GameObject[] image = new GameObject [3];
	public UnityEngine.UI.Button yourButton;
	private bool Active = false;
	private float Porcentaje = 0.0f;
	private int index = 0;

	void Start()
	{
		UnityEngine.UI.Button btn = yourButton.GetComponent<UnityEngine.UI.Button>();
		btn.onClick.AddListener(TaskOnClick);
		Contador = 0;
	}

	void TaskOnClick()
	{
		image[index].SetActive(true);
		Active = true;
		Porcentaje++;
		index++;

	}

	// Update is called once per frame
	void Update()
	{
		if (Active)
		{
			if (Contador <= tiempo)
			{
				Contador = Porcentaje + Time.deltaTime;
				Circle.fillAmount =  Contador / 10 ;
				TextCharge.text = (Convert.ToInt32(100 * Circle.fillAmount)).ToString() + "%";
			}
		}

	}


}
