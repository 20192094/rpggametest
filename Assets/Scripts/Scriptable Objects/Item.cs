using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Item")]

public class Item : ScriptableObject
{
    public string objectName; //object name
    public Sprite sprite; //object image
    public int quantity;
    public bool stackable;
    public enum ItemType //item type
    {
        COIN,
    }
    public ItemType itemType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
