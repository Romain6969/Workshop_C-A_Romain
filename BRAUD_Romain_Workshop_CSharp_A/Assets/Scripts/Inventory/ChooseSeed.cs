using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSeed : MonoBehaviour
{
    [field: SerializeField] public int WichSeed { get; private set;}
    [SerializeField] private List<Outline> _seedOutline;

    private void Start()
    {
        _seedOutline[0].enabled = false;
        _seedOutline[1].enabled = false;
        _seedOutline[2].enabled = false;
        _seedOutline[3].enabled = false;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            WichSeed = 0;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            WichSeed = 1;
        }
        else if(Input.GetKey(KeyCode.Alpha3))
        {
            WichSeed = 2;
        }
        else if(Input.GetKey(KeyCode.Alpha4))
        {
            WichSeed = 3;
        }
        switch (WichSeed)
        {
            case 0:
                _seedOutline[0].enabled = true;
                _seedOutline[1].enabled = false;
                _seedOutline[2].enabled = false;
                _seedOutline[3].enabled = false;
                break;
            case 1:
                _seedOutline[1].enabled = true;
                _seedOutline[0].enabled = false;
                _seedOutline[2].enabled = false;
                _seedOutline[3].enabled = false;
                break;
            case 2:
                _seedOutline[2].enabled = true;
                _seedOutline[0].enabled = false;
                _seedOutline[1].enabled = false;
                _seedOutline[3].enabled = false;
                break;
            default:
                _seedOutline[3].enabled = true;
                _seedOutline[0].enabled = false;
                _seedOutline[1].enabled = false;
                _seedOutline[2].enabled = false;
                break;
        }
    }
}
