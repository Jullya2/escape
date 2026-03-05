using UnityEngine;

public class DoorController : MonoBehaviour
{
    public PressurePlate plate1;
    public PressurePlate plate2;

    void Update()
    {
        if (plate1.activated && plate2.activated)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true); 
        }
    }
}