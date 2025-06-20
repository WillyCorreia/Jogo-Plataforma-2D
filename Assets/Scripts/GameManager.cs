using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using DG.Tweening;


public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;

    [Header("Enemies")]
    public List<GameObject> enemies;

    [Header ("References")]
    public Transform startPoint;

    public GameObject _currentPlayer;

    [Header("Animation")]
    public float duration = .2f;
    public Ease ease = Ease.OutBack;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = startPoint.transform.position;
        _currentPlayer.transform.DOScale(0, duration).SetEase(ease).From();
    }

}
