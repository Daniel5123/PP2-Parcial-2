using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public int ActiveSlot = 0;
    public Transform Slots;
    public Transform[] InventorySlots;

    private void Start()
    {
        InventorySlots = Slots.GetComponentsInChildren<Transform>();
        InventorySlots[ActiveSlot].GetChild(0).gameObject.SetActive(true);

    }

    private void Update()
    {
        InventorySlots[ActiveSlot].GetChild(0).gameObject.SetActive(true);
    }
} 
