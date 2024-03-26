using UnityEngine;

public class ChooseSeed : MonoBehaviour
{
    [field: SerializeField] public int WichSeed { get; private set;}

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            WichSeed += 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            WichSeed -= 1;
        }
        else if(WichSeed < 0)
        {
            WichSeed = 3;
        }
        else if(WichSeed > 3)
        {
            WichSeed = 0;
        }
    }
}
