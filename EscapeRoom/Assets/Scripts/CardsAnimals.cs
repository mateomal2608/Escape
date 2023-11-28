using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardsAnimals : MonoBehaviour
{
    public UnityEvent soundAction;
    public Sprite face;
    public Sprite back;

    myControls inputActions;

    private void Awake()
    {
        inputActions = new myControls();
    }

   
    private void OnMouseDown()
    {
        Debug.Log("Enter the space");
        soundAction.Invoke();
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
