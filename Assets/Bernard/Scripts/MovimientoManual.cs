using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoManual : MonoBehaviour
{
    [SerializeField] KeyCode teclaArriba;
    [SerializeField] KeyCode teclaAbajo;
    [SerializeField] KeyCode teclaDerecha;
    [SerializeField] KeyCode teclaIzquierda;

    [SerializeField] float velocidad = 0.01f;

    void Update()
    {
        if (Input.GetKey(teclaArriba))
        {
            //mover hacia arriba
            transform.Translate(Vector3.up * velocidad);
        }

        if (Input.GetKey(teclaAbajo))
        {
            //mover hacia abajo
            transform.Translate(Vector3.down * velocidad);
        }

        if (Input.GetKey(teclaDerecha))
        {
            //mover hacia derecha
            transform.Translate(Vector3.right * velocidad);
        }

        if (Input.GetKey(teclaIzquierda))
        {
            //mover hacia izquierda
            transform.Translate(Vector3.left * velocidad);
        }
    }
}