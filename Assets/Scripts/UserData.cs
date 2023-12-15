using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData_", menuName = "ATM Data/UserData", order = 0)]
public class UserData : ScriptableObject
{
    public string userId;
    public string userName;
    public int cash;
    public int balance;
}
