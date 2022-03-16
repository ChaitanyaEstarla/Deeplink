using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject mainPanel;
    
    public void OnBack()
    {
        gameObject.SetActive(false);
        mainPanel.SetActive(true);
    }
}
