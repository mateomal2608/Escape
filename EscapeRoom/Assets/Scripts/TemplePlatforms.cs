using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TemplePlatforms : MonoBehaviour
{
    public UnityEvent soundAction;
    private int counter;
    public GameObject platform;

    

    myControls inputActions;

    private void Awake()
    {
        inputActions = new myControls();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inputActions.Player.ActionKey.WasPerformedThisFrame()&& counter==0)
            {
                counter++;
                Debug.Log("Win");
                soundAction.Invoke();
            }
            else if(inputActions.Player.ActionKey.WasPerformedThisFrame() && counter != 0)
            {
                platform.SetActive(false);
                
            }
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
