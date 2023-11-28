using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardsAnimals : MonoBehaviour
{
    public UnityEvent soundAction;
    public Sprite[] faces;
    public Sprite back;
    SpriteRenderer spriteRenderer;
    public int faceIndex=0;
    GameObject matchControl;
    public bool matched=false;
    public int counter=0;

    myControls inputActions;

    private void Awake()
    {
        inputActions = new myControls();
        spriteRenderer=GetComponent<SpriteRenderer>();
        matchControl = GameObject.Find("WeaponPedestal");
    }

   
    private void OnMouseDown()
    {
        if (matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (matchControl.GetComponent<MatchingGame>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex];
                    matchControl.GetComponent<MatchingGame>().AddVisibleFace(faceIndex);
                    matched = matchControl.GetComponent<MatchingGame>().CheckMatch();
                }

            }
            else
            {
                spriteRenderer.sprite = back;
                matchControl.GetComponent<MatchingGame>().RemoveVisibleFace(faceIndex);

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
