using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // [SerializeField] private CustomerManager customerManager;
    [SerializeField] private TMP_Text customerText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting");
        if (CustomerManager.Instance.chosenWeapon == "mace")
        {
            customerText.text = "My thanks, good smith. With this, I will be able to stop any wrongdoers with non lethal force";
        }
        if (CustomerManager.Instance.chosenWeapon == "sword" || CustomerManager.Instance.chosenWeapon == "dagger")
        {
            customerText.text = "Have I not just told you that my goddess forbids killing? How dare you present me with a bladed weapon! The church will hear of this";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChooseWeapon(string weaponName)
    {
        CustomerManager.Instance.chosenWeapon = weaponName;
    }
}
