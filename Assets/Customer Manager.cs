using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerManager : MonoBehaviour
{
    public static CustomerManager Instance;

    [SerializeField] private int iron;

    private string chosenWeapon = "";
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GoToForging()
    {
        Debug.Log("loading forging scene");
        SceneManager.LoadScene(1);
    }

    public void ChooseWeapon(string weapon)
    {
        chosenWeapon= weapon;
    }
}
