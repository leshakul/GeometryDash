using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class WinGameOverScreen : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private CanvasGroup _canvasGroup;

    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;
    }

    private void OnEnable()
    {
        _player.Won += OnWon;
    }

    private void OnDisable()
    {
        _player.Won -= OnWon;
    }

    private void OnWon()
    {
        _canvasGroup.alpha = 1;
        Time.timeScale = 0;
    }
}
