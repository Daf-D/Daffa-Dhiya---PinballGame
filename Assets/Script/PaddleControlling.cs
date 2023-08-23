using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControlling : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    public float springpower;

    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring = springpower;
        }
        else
        {
            jointSpring.spring = 0;
        }
        hinge.spring = jointSpring;
    }
}
