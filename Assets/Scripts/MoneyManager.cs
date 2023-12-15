using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    public UserData userData;
    private void Awake()
    {
        instance = this;
    }
}
