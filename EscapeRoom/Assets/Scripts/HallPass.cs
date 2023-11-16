using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class HallPass : MonoBehaviour
{
    public ParticleSystem[] tourches;
    public UnityEvent winnerAction;

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
                if (tourches[0].isStopped&& tourches[5].isStopped&& tourches[2].isStopped && tourches[3].isStopped)
                {
                    Debug.Log("Win");
                    winnerAction.Invoke();
                }
                
                   
                
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
