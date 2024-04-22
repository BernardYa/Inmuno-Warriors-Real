using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigo : MonoBehaviour
{
    [SerializeField] private float vida;

    public void TomarDaño(float daño)
    {
        vida -= daño; 

        if (vida <=0)
        {
            Destroy (gameObject);
        }