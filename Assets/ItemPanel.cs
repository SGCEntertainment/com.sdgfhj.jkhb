using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    public static ItemPanel instance;
    [SerializeField] private TextMeshProUGUI teamName;
    [SerializeField] private TextMeshProUGUI teamDes;
    [SerializeField] private Image _sprite;

    private void Awake()
    {
        instance = this;
    }

    public void SetRes(string teamname, string teamdes, Sprite sprite)
    {
        teamName.text = teamname;
        teamDes.text = teamdes;
        _sprite.sprite = sprite;
    }
}
