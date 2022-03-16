using UnityEngine;

public class StringManager : MonoBehaviour
{
    private static string m_S = "unitydl://mylink?shop/rc";
    
    private string[] m_Subs = m_S.Split('?');
    
    private void Awake()
    {
        var remoteActions = m_Subs[1].Split('/');
    
        foreach (var remoteAction in remoteActions)
        {
            Debug.Log(remoteAction);
        }
    }

    private string instanceName;

    public StringManager(string name)
    {
        instanceName = name;
    }

    public void DisplayToConsole()
    {
        Debug.Log(instanceName);
    }
}