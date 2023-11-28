using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchingGame : MonoBehaviour
{

    public GameObject podiumScreen;
    public UnityEvent soundAction;
    public GameObject[] cardLeft;
    public GameObject[] cardRight;
    public int counter;


    myControls inputActions;

    private void Awake()
    {
        inputActions = new myControls();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inputActions.Player.ActionKey.WasPerformedThisFrame())
            {
                Debug.Log("Enter the space");
                soundAction.Invoke();
            }
        }

    }

    public void pairs()
    {
        counter++;

        if(counter%2==0)
        {
            if (!cardLeft[0].activeInHierarchy && !cardRight[3].activeInHierarchy)
            {
                Debug.Log("Hola");

            }

            else if (!cardLeft[1].activeInHierarchy && !cardRight[7].activeInHierarchy)
            {
                Debug.Log("HolaX2");
            }

            else
            {
                foreach (GameObject card in cardLeft)
                {
                    card.SetActive(true);
                }
                foreach (GameObject card in cardRight)
                {
                    card.SetActive(true);
                }
            }
        }

       
        //else 
        //{
        //    
        //}
        
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

    public void OnEnable()
    {
        inputActions.Player.Enable();
    }

    public void OnDisable()
    {
        inputActions.Player.Disable();
    }
}
