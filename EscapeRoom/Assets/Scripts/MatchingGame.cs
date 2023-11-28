using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MatchingGame : MonoBehaviour
{

    public GameObject podiumScreen;
    public UnityEvent soundAction;
    public GameObject token;
    List<int> faceIndexes =  new List<int> { 0, 1, 2, 3, 4 , 5, 6, 7 ,0, 1, 2, 3, 4, 5, 6, 7 };
    public static System.Random rnd = new System.Random();
    private int shuffleNum = 0;
    int[] visibleFaces = { -1, -2 };
    public int match = 0;
    private int pairs = 8;
    public bool finished=false;
    public TMP_Text[] text;

    myControls inputActions;

   

    // Start is called before the first frame update
    void Start()
    {
        float yPosition = 22f;
        float zPosition = 19f;

        for(int i = 0; i< 16;i++)
        {
            shuffleNum = rnd.Next(0, faceIndexes.Count);
            var rotation = Quaternion.Euler(0f, -90f, 0f);
            var temp = Instantiate(token, new Vector3(-45f, yPosition, zPosition), rotation);
            temp.GetComponent<CardsAnimals>().faceIndex = faceIndexes[shuffleNum];
            faceIndexes.Remove(faceIndexes[shuffleNum]);
            

            zPosition = zPosition + 2;

            if(i==3)
            {
                yPosition = 20f;
                zPosition = 19f;
            }
            if(i==7)
            {
                yPosition = 18f;
                zPosition = 19f;
            }
            if(i==11)
            {
                yPosition = 16f;
                zPosition = 19f;
            }    
        }


    }

   

   public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if (visibleFaces[0] >=0 && visibleFaces[1]>=0)
        {
            cardsUp = true;
        }
        return cardsUp;
    }

    public void AddVisibleFace(int index)
    {
        if (visibleFaces[0] == -1)
        {
            visibleFaces[0] = index;
        }
        else if (visibleFaces[1] == -2)
        {
            visibleFaces[1] = index;
        }

    }

    public void RemoveVisibleFace(int index)
    {
        if (visibleFaces[0] == index)
        {
            visibleFaces[0] = -1;
        }
        else if (visibleFaces[1] == index)
        {
            visibleFaces[1] = -2;
        }
    }


    public bool CheckMatch()
    {
        bool success = false;
        if (visibleFaces[0] == visibleFaces[1])
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            match++;          
        }
        return success;
    }



    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        token = GameObject.Find("Token");
        inputActions = new myControls();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inputActions.Player.ActionKey.WasPerformedThisFrame())
            {
                if (match == pairs)
                {
                    text[0].gameObject.SetActive(false);
                    text[1].gameObject.SetActive(true);
                    Debug.Log("Win");
                    finished = true;
                    soundAction.Invoke();
                }

                
            }
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

    public void OnEnable()
    {
        inputActions.Player.Enable();
    }

    public void OnDisable()
    {
        inputActions.Player.Disable();
    }
}
