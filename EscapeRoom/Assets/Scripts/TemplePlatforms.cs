using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TemplePlatforms : MonoBehaviour
{
    public UnityEvent soundAction;
    public GameObject platform;
    public int counter;
    public GameObject[] collidableObjects;
    public TMP_Text[] questions;
    private myControls inputActions;
    public GameObject podiumScreen;


    public void FirstAns()
    {
        
        if(counter == 0)
        {
            questions[0].gameObject.SetActive(false);
            questions[1].gameObject.SetActive(true);
            Debug.Log("Win");

        }
        else
        {
            platform.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter the space");
            LeanTween.scale(podiumScreen, Vector3.one, 2);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Leave the space");
            LeanTween.scale(podiumScreen, Vector3.zero, 2).setEaseInQuad();

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
