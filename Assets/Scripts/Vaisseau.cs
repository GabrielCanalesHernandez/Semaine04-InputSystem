using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vaisseau : MonoBehaviour
{
    // Start is called before the first frame update

    private float _valeurX;
    private float _valeurY;
    private Vector2 _mouvementHorizontal;

    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Bouge();
    }

    public void RecevoirInfo(InputAction.CallbackContext context){
        Debug.Log(context.ReadValue<Vector2>()); //(1,0) (-1,0) (0,0)
    }

    public void Bouge()
    {
        Vector2 _mouvement = new Vector2 (2,4);
        _rb.AddForce(_mouvementHorizontal*40,ForceMode.Force);
    }

    public void GaucheDroite(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        _mouvementHorizontal = context.ReadValue<Vector2>();
        _valeurX = _mouvementHorizontal.x;
        _valeurX = _mouvementHorizontal.y;
    }
}
