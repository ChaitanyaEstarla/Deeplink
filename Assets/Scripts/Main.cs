using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject shopPanel;

    public delegate void OnURLCall();
    public static event OnURLCall OnUrlCall;

    private void Start()
    {
        OnUrlCall += ToggleShop;
    }

    private void ToggleShop()
    {
        shopPanel.gameObject.SetActive(!shopPanel.gameObject.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

    private void OnDestroy()
    {
        OnUrlCall -= ToggleShop;
    }

    public static void OnOnURLCall()
    {
        OnUrlCall?.Invoke();
    }
}
