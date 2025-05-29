using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButonsManager : MonoBehaviour
{
    public List<GameObject> Buttons;

    [Header ("Animation")]
    public float duration = .2f;
    public float delay = .05f;

    private void Awake()
    {
        HideAllButtons();
        ShowButtons();
    }

    private void HideAllButtons()
    {
        foreach (var button in Buttons)
        {
            button.transform.localScale = Vector3.zero;
            button.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        for(int i = 0; i < Buttons.Count; i++)
        {
            var button = Buttons[i];
            button.SetActive(true);
            button.transform.DOScale(1, duration).SetDelay(i*delay);
        }
    }
}
