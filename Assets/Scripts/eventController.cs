using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventController : MonoBehaviour
{
    public bool[] can_interact;
    // Start is called before the first frame update
    void Start()
    {
        can_interact[0] = false;    //���ॴ�}box
        can_interact[1] = true;     //�i�H���okey
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStatus(int id, bool value)
    {
        can_interact[id] = value;
    }

    public bool CheckStatus(int id)
    {
        return can_interact[id];
    }
}
