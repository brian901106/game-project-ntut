using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch0_BController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!GameManager.eventController.CheckIfProblemSolved(0))
        {
            GameManager.clue.GetTool(0);

            GameManager.eventController.SolveProblem(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
