using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    Vector3 rotation;

    private void Start() {

        var xRotation = Random.Range(0.2f, 1f);
        rotation = new Vector3(-xRotation, 0);
    }

    private void Update(){

        transform.Rotate(rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Se for colidido com outro objeto Hazard (caixa) não deve ser destruido.
        if (!collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }
}
