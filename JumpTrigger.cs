using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public float boost = 5.0f;

    void OnTriggerEnter(Collider other)
    {
        //���������� ������
        other.GetComponent<Jump>().jumpStrength *= boost;
    }

    void OnTriggerExit(Collider other)
    {
        //���������� ������
        other.GetComponent<Jump>().jumpStrength /= boost;
    }
}
