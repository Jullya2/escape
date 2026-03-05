using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    public int keys = 0;

    public void AddKey()
    {
        keys++;
        Debug.Log("Chave coletada! Total: " + keys);
    }

    public bool UseKey()
    {
        if (keys > 0)
        {
            keys--;
            return true;
        }

        return false;
    }
}