using UnityEngine;

public class LeverController : MonoBehaviour
{
    public int totalLevers = 2;
    private int activatedLevers = 0;
    public GameObject door;

    public void ActivateLever()
    {
        activatedLevers++;

        if (activatedLevers >= totalLevers)
        {
            door.SetActive(false);
        }
    }
}