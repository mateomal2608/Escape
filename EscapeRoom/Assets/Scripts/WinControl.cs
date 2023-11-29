using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class WinControl : MonoBehaviour
{
    public GameObject winScreen;
    public UnityEvent finalSound;
    myControls inputActions;
    public GameObject matching;
    public GameObject statues;
    public TMP_Text[] instructions;
    


    private void Awake()
    {
        inputActions = new myControls();
        matching = GameObject.Find("WeaponPedestal");
        statues = GameObject.Find("SwitchStanding");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inputActions.Player.ActionKey.WasPerformedThisFrame())
            {
                if(matching.GetComponent<MatchingGame>().finished==true && statues.GetComponent<TemplePlatforms>().finished==true)
                {
                    finalSound.Invoke();
                    instructions[0].gameObject.SetActive(false);
                    instructions[1].gameObject.SetActive(true);
                    

                }

            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter the space");
            LeanTween.scale(winScreen, Vector3.one, 2);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Leave the space");
            LeanTween.scale(winScreen, Vector3.zero, 2).setEaseInQuad();

        }
    }
    public void OnEnable()
    {
        inputActions.Player.Enable();
    }

    public void OnDisable()
    {
        inputActions.Player.Disable();
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
