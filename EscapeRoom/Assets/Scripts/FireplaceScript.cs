using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireplaceScript : MonoBehaviour
{
    public GameObject fireplaceScreen;
    public UnityEvent finalSound;
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
                finalSound.Invoke();

            }
        }

    }
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
