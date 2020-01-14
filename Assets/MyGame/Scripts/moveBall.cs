using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveBall : MonoBehaviour
{
    public GameObject Ball;
    [SerializeField] private GameObject[] BallPositions;


    private int RandomNumber()
    {
        return Random.Range(0, 4);
    }

    public void secondNumber()
    {
        Ball.transform.position = BallPositions[RandomNumber()].transform.position;

    }
}

