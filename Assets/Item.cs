using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Sprite _sprite;
    [SerializeField] private string teamDes;
    [SerializeField] private Image image;

    private void Start()
    {
        _sprite = image.sprite;
    }
    public void Get()
    {
        ItemPanel.instance.SetRes(_sprite.name, teamDes, _sprite);
    }
}
