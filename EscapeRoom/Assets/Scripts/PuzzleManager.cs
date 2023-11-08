using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleManager : MonoBehaviour
{

    public GameObject[] puzzleHolder1;
    public GameObject[] puzzleHolder2;
    public GameObject[] puzzleHolder3;
    public UnityEvent winnerAction;

    private int greenCounter;
    private int redCounter;
    private int pinkCounter;

    public void Winner()
    {
        if (puzzleHolder1[0].activeInHierarchy && puzzleHolder2[1].activeInHierarchy && puzzleHolder3[2].activeInHierarchy)
        {
            Debug.Log("You Win");
            winnerAction.Invoke();
        }

       
    }


    public void GreenATM()
    {
        greenCounter++;

        switch(greenCounter)
        {
            case 0:
                puzzleHolder1[0].SetActive(true);
                puzzleHolder1[1].SetActive(false);
                puzzleHolder1[2].SetActive(false);
                break;
            case 1:
                puzzleHolder1[0].SetActive(false);
                puzzleHolder1[1].SetActive(true);
                puzzleHolder1[2].SetActive(false);
                break;
            case 2:
                puzzleHolder1[0].SetActive(false);
                puzzleHolder1[1].SetActive(false);
                puzzleHolder1[2].SetActive(true);
                break;
            case 3:
                puzzleHolder1[0].SetActive(true);
                puzzleHolder1[1].SetActive(false);
                puzzleHolder1[2].SetActive(false);
                greenCounter =0;
                break;

            default:
                break;
        }
    }

    public void RedATM()
    {
        redCounter++;

        switch (redCounter)
        {
            case 0:
                puzzleHolder2[0].SetActive(true);
                puzzleHolder2[1].SetActive(false);
                puzzleHolder2[2].SetActive(false);
                break;
            case 1:
                puzzleHolder2[0].SetActive(false);
                puzzleHolder2[1].SetActive(true);
                puzzleHolder2[2].SetActive(false);
                break;
            case 2:
                puzzleHolder2[0].SetActive(false);
                puzzleHolder2[1].SetActive(false);
                puzzleHolder2[2].SetActive(true);
                break;
            case 3:
                puzzleHolder2[0].SetActive(true);
                puzzleHolder2[1].SetActive(false);
                puzzleHolder2[2].SetActive(false);
                redCounter = 0;
                break;

            default:
                break;
        }
    }
    public void PinkATM()
    {
        pinkCounter++;

        switch (pinkCounter)
        {
            case 0:
                puzzleHolder3[0].SetActive(true);
                puzzleHolder3[1].SetActive(false);
                puzzleHolder3[2].SetActive(false);
                break;
            case 1:
                puzzleHolder3[0].SetActive(false);
                puzzleHolder3[1].SetActive(true);
                puzzleHolder3[2].SetActive(false);
                break;
            case 2:
                puzzleHolder3[0].SetActive(false);
                puzzleHolder3[1].SetActive(false);
                puzzleHolder3[2].SetActive(true);
                break;
            case 3:
                puzzleHolder3[0].SetActive(true);
                puzzleHolder3[1].SetActive(false);
                puzzleHolder3[2].SetActive(false);
                pinkCounter = 0;
                break;

            default:
                break;
        }
    }


}
