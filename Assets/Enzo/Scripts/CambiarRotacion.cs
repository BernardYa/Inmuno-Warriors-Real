using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRotacion : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        float anguloRadianes = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}