using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireplaceScript : MonoBehaviour
{
    public GameObject fireplaceScreen;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter the space");
            LeanTween.scale(fireplaceScreen, Vector3.one, 2);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Leave the space");
            LeanTween.scale(fireplaceScreen, Vector3.zero, 2).setEaseInQuad();

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
