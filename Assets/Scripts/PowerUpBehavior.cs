using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField] private string PowerUpType;
    
    public string GetPowerUp() {
        return PowerUpType;
    }
}
