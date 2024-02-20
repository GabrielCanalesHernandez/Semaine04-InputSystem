using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeCubeInt : MonoBehaviour
{

    // Start is called before the first frame update

    [SerializeField] private GameObject _cubeDedans;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.tag);

        if(other.gameObject.CompareTag("Sol")){
            
            _cubeDedans.SetActive(true);

        }

    }
}
