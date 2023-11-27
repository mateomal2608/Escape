using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TemplePlatforms : MonoBehaviour
{
    public UnityEvent soundAction;
    public GameObject[] platform;
    public int counter;
    public GameObject[] collidableObjects;
    public TMP_Text[] questions;
    private myControls inputActions;
    public GameObject podiumScreen;


    public void FirstAns()
    {
        counter++;
        
        if(counter == 1)
        {
            questions[0].gameObject.SetActive(false);
            questions[1].gameObject.SetActive(true);
            Debug.Log("Win");

        }
        else if(counter==3)
        {
            questions[2].gameObject.SetActive(false);
            questions[3].gameObject.SetActive(true);
            Debug.Log("Win");
        }
        else
        {
            platform[2].SetActive(false);
        }

    }

    public void SecondAns()
    {
        counter++;

        if (counter == 2)
        {
            questions[1].gameObject.SetActive(false);
            questions[2].gameObject.SetActive(true);
            Debug.Log("Win");

        }
        else
        {
            platform[1].SetActive(false);
        }

    }

    public void fourthAns()
    {
        counter++;

        if (counter == 4)
        {
            questions[3].gameObject.SetActive(false);
            questions[4].gameObject.SetActive(true);
            Debug.Log("Win");

        }
        else
        {
            platform[3].SetActive(false);
        }

    }

    public void otherAns()
    {
        platform[0].SetActive(false);

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
