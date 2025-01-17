﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLowPolyBox : AbstractInteractable
{

    private GameObject player; 

    private GameObject objetoMirado;

    public bool inventarioVacio;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        player = GameObject.FindWithTag("Player");
        objetoMirado = this.gameObject;
    }

    public override void OnPointerEnter(){
        Debug.Log("Entrada al cubo");
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public override void OnPointerExit()
    {
        Debug.Log("Salida del cubo");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    public override void HaSidoMirado()
    {
        InventarioScript inventario = player.GetComponent<InventarioScript>();
        inventario.NuevoObjetoEnInventario(objetoMirado);
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
