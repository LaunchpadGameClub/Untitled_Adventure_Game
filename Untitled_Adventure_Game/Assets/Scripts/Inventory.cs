using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inv;
    public int columns;
    public int rows;
    public GameObject slotParent;
    public GameObject slot;
    public GameObject[] slots;
    public List<Item> items;
    private Color transparent = 
    new Color32(255, 255, 255, 0);
    private Color opaque = 
    new Color32(255, 255, 255, 255);

    //List<items> inventory = new List<items>();
    // Start is called before the first frame update
    void Start()
    {
        Rect rt = slotParent.GetComponent<RectTransform>().rect;
        float blockLength;
        if(rt.width/columns > rt.height/rows)
        {
            blockLength = (rt.height/rows);
        }
        else
        {
            blockLength = (rt.width/columns);
        }
        float cellsize = blockLength * .85f;
        Vector2 spacing = new Vector2(((rt.width)-(cellsize*columns))/columns, 
                                        ((rt.height)-(cellsize*rows))/rows);
        GridLayoutGroup glg = slotParent.GetComponent<GridLayoutGroup>();
        glg.cellSize = new Vector2(cellsize, cellsize);
        glg.spacing = spacing;
        glg.constraintCount = columns;
        slots = new GameObject[columns * rows];
        GenerateSlots();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnValidate() 
    {
        DisplayItems();
    }

    void GenerateSlots()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(slots[i] == null)
            {
                GameObject go = Instantiate(slot, 
                new Vector3(0,0,0), Quaternion.identity);
                go.transform.SetParent(slotParent.transform);
                slots[i] = go;
            }
        }
    }

    public void DisplayItems()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(slots[i] != null)
            {
                GameObject child = slots[i].transform.GetChild(0).gameObject;
                Image img = child.GetComponent<Image>();
                img.sprite = items[i].image;
                // img.sprite = items.ElementAt(i).image;
                img.color = opaque;
            }
        }
    }
}
