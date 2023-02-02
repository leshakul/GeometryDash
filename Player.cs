using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction Died;
    public event UnityAction Won;

    public void Die()
    {
        Died?.Invoke();
    }

    public void Win()
    {
        Won?.Invoke();
    }
}
