using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoneyBtn : MonoBehaviour
{
    [SerializeField] private GameObject NoMoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        NoMoney.SetActive(false);
    }
}
